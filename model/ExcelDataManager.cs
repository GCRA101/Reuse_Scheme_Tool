﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Media.Imaging;
using Microsoft.Office.Interop.Excel;
using ReuseSchemeTool.model;

public class ExcelDataManager
{
    // ATTRIBUTES
    private Application ExcelApp;
    private Workbook ExcelWkb;
    private Worksheet ExcelWks;

    private string filePath;
    private string outputsFolderPath;


    // CONSTRUCTORS
    public ExcelDataManager(string filePath = "")
    {
        // Throw an exception if the input filepath provided doesn't correspond to an excel file
        if (filePath != "" && !(filePath.Contains(".xlsx") || filePath.Contains(".xlsm") || filePath.Contains(".xls")))
        {
            throw new InvalidFilePathException("The filepath provided doesn't correspond to an excel file.");
        }

        // Assign the filePath attribute with the filePath string input if this corresponds to an excel file
        this.filePath = filePath;
    }

    public ExcelDataManager(string embeddedfilePath, string outputsFolderPath) 
    {
        // Throw an exception if the input filepath provided doesn't correspond to an excel file
        if (embeddedfilePath != "" && !(embeddedfilePath.Contains(".xlsx") || embeddedfilePath.Contains(".xlsm") || embeddedfilePath.Contains(".xls")))
        {
            throw new InvalidFilePathException("The filepath provided doesn't correspond to an excel file.");
        }

        Stream excelStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(embeddedfilePath);

        if (excelStream != null)
        {
            // Create a temporary file
            string tempFilePath = outputsFolderPath + "\\" + Path.GetFileName(embeddedfilePath);
            File.WriteAllBytes(tempFilePath, readFully(excelStream));
            this.filePath = tempFilePath;
            return;
        }
    }

    // Helper method to read the stream fully
    private static byte[] readFully(Stream input)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            input.CopyTo(ms);
            return ms.ToArray();
        }
    }



    // METHODS
    public void initialize(bool excelAppVisible = false)
    {
        // 1. INITIALIZE EXCEL APPLICATION
        ExcelApp = new Application();
        ExcelApp.Visible = excelAppVisible;

        // 2. OPEN/CREATE EXCEL WORKBOOK
        if (filePath == "")
        {
            ExcelWkb = ExcelApp.Workbooks.Add();
        }
        else if (filePath.Contains(".xlsx") || filePath.Contains(".xlsm") || filePath.Contains(".xls"))
        {
            ExcelWkb = ExcelApp.Workbooks.Open(filePath);
        }
    }


    private void activateWorksheet(string worksheetName)
    {
        // 1. OPEN/CREATE EXCEL WORKSHEET
        if (ExcelWkb.Worksheets.Cast<Worksheet>().Select(wks => wks.Name).Contains(worksheetName))
        {
            ExcelWks = ExcelWkb.Worksheets[worksheetName];
        }
        else
        {
            ExcelWks = ExcelWkb.Worksheets.Add();
            ExcelWks.Name = worksheetName;
        }
        ExcelWks.Tab.ColorIndex = (XlColorIndex)6;
        ExcelWks.Activate();

    }

    public void hideWorksheet(string worksheetName)
    {
        if (ExcelWkb.Worksheets.Cast<Worksheet>().Select(wks => wks.Name).Contains(worksheetName))
        {
            ExcelWkb.Worksheets[worksheetName].Visible=XlSheetVisibility.xlSheetHidden;
        }

    }

    public void protectWorkbook(bool protect)
    {
        if (protect) ExcelWkb.Protect();
        else ExcelWkb.Unprotect();
    }

    public void printWorkSheet(string worksheetName, string folderPath)
    {
        if (ExcelWkb.Worksheets.Cast<Worksheet>().Select(wks => wks.Name).Contains(worksheetName))
        {
            Worksheet wks = ExcelWkb.Worksheets[worksheetName];
            wks.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, folderPath + "\\" + wks.Name + ".pdf"); 
        }
    }


    public void write(string[] data, string worksheetName, string[] cellAddresses)
    {
        // 1. OPEN/CREATE EXCEL WORKSHEET
        this.activateWorksheet(worksheetName);

        for (int i = 0; i < data.Length; i++)
        {
            this.ExcelWks.Range[cellAddresses[i]].Value = data[i];   
        }
    }

    public void write<T>(List<T> data, string worksheetName, string startCellAddress, string[] headerTitles = null) where T: SteelFrame
    {
        // 1. OPEN/CREATE EXCEL WORKSHEET
        this.activateWorksheet(worksheetName);

        // 2. POSITION ACTIVE CELL
        if (ExcelWks.Range[startCellAddress] == null) return;


        string[,] matrix=new string[data.Count,5];
        ExistingSteelFrame existingFrame;

        for (int i=0; i<data.Count; i++)
        {
            existingFrame = data[i] as ExistingSteelFrame;
            matrix[i,0]= existingFrame.getSectionType().ToString();
            matrix[i,1] = existingFrame.getSection().getName();
            matrix[i,2] = Math.Round(existingFrame.getSection().getArea(), 3).ToString();
            matrix[i,3] = Math.Round(existingFrame.getLength(), 3).ToString();
            matrix[i,4] = existingFrame.getReuseRating().ToString();
        }

        Range topLeftCell = ExcelWks.Range[startCellAddress];
        Range btmRightCell = ExcelWks.Range[startCellAddress].Offset[data.Count()-1, 4];
        Range outputsRange = ExcelApp.Range[topLeftCell, btmRightCell];

        outputsRange.Value = matrix;

        this.ExcelApp.ActiveCell.CurrentRegion.EntireColumn.AutoFit();
    }


    public void SetFilePath(string filePath)
    {
        if (filePath != "" && !(filePath.Contains(".xlsx") || filePath.Contains(".xlsm") || filePath.Contains(".xls")))
        {
            throw new InvalidFilePathException("The filepath provided doesn't correspond to an excel file.");
        }
        this.filePath = filePath;
    }

    public void dispose()
    {
        if (this.filePath != "")
        {
            ExcelWkb.Save();
            ExcelWkb.Close();
            ExcelApp = null;
        }
    }

    public void FormatRange(Range range, ExcelRangeType excelRangeType)
    {
        // Assign specific Range Format based on input ExcelRangeType Enum value
        switch (excelRangeType)
        {
            case ExcelRangeType.HEADER_PRIMARY:
                // Call private FormatRange() method with pre-set inputs
                FormatRange(range, "Segoe UI", 10, true, XlHAlign.xlHAlignCenter, XlVAlign.xlVAlignCenter, XlLineStyle.xlContinuous,
                    XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexNone, XlPattern.xlPatternLinearGradient, 90,
                    XlThemeColor.xlThemeColorAccent6, false);
                break;
            case ExcelRangeType.HEADER_SECONDARY:
                // Call private FormatRange() method with pre-set inputs
                FormatRange(range, interiorColor: (XlColorIndex)19);
                break;
            case ExcelRangeType.NORMAL:
                // Call private FormatRange() method with pre-set inputs
                FormatRange(range);
                break;
        }
    }

    private void FormatRange(Range range, string fontName = "Segoe UI", int fontSize = 10, bool fontBold = false,
    XlHAlign textHorAlignment = XlHAlign.xlHAlignCenter, XlVAlign textVertAlignment = XlVAlign.xlVAlignCenter,
    XlLineStyle borderLineStyle = XlLineStyle.xlContinuous, XlBorderWeight borderLineWeight = XlBorderWeight.xlThin,
        XlColorIndex interiorColor = XlColorIndex.xlColorIndexNone, XlPattern interiorPattern = XlPattern.xlPatternNone,
        int gradientDegree = 0, XlThemeColor gradientThemeColor = XlThemeColor.xlThemeColorDark1, bool autoFit = true)
    {
        // Font
        range.Font.Name = fontName;
        range.Font.Bold = fontBold;
        range.Font.Size = fontSize;

        // Text Alignment
        range.HorizontalAlignment = textHorAlignment;
        range.VerticalAlignment = textVertAlignment;

        // Color Pattern
        if (interiorPattern != XlPattern.xlPatternNone)
        {
            range.Interior.ColorIndex = interiorColor;
            range.Interior.Pattern = interiorPattern;
            range.Interior.Gradient.Degree = gradientDegree;
            range.Interior.Gradient.ColorStops.Add(0).ThemeColor = gradientThemeColor;
            range.Interior.Gradient.ColorStops.Add(0).TintAndShade = 0.400006103701895;
        }

        // Edges
        XlBordersIndex[] edgeTypes = { XlBordersIndex.xlEdgeLeft, XlBordersIndex.xlEdgeTop,
                                       XlBordersIndex.xlEdgeRight, XlBordersIndex.xlEdgeBottom };

        edgeTypes.ToList().ForEach(edgeType =>
        {
            range.Borders[edgeType].LineStyle = borderLineStyle;
            range.Borders[edgeType].Weight = borderLineWeight;
        });

        // Autofit
        if (autoFit) range.EntireColumn.AutoFit();
    }

    public void refreshWorkbook()
    {
        this.ExcelWkb.RefreshAll();
    }
}