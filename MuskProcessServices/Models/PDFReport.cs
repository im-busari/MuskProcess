using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Web.Hosting;
using System.Windows.Forms;

namespace MuskProcessServices.Models
{
    class PDFReport
    {
        public static void generatePDF(int siteInspectionId)
        {
            //  Attributes
            PdfPTable table = null;
            Phrase phrase = null;
            PdfPCell cell = null;
            BaseColor color = null;

            //  Getting the full path to the folder where we store our reports
            string reportsFolder = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", "./Reports"));

            System.IO.FileStream fs = new FileStream( reportsFolder + "\\" + $"SiteInspection_{siteInspectionId}.pdf", FileMode.OpenOrCreate);
            
            //  Creating an instance of the document which represents the PDF file
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            //  Meta information
            document.AddAuthor("JEMP");
            document.AddKeywords("Site Inspection generated report from DB");
            document.AddSubject("A summary report of the site inspection and listed interventions");
            document.AddTitle($"Site Inspection_{siteInspectionId} report");

            // Open document to include changes
            document.Open();

            // Title of document
            Font titleFont = FontFactory.GetFont("Arial", 15, Font.BOLD);
            Paragraph title = new Paragraph("Health, Safety, Quality and Environmental Site Inspection", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            //Site Inspection summary details table
            table = new PdfPTable(6);
            table.TotalWidth = 550f;
            table.LockedWidth = true;

            /*cell = new PdfPCell(new Phrase("Row 1 , Col 1, Col 2 and col 3"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;*/
            //  1st row
            table.AddCell(HeaderCell("Site:"));
            table.AddCell(ValueCell("1234"));
            table.AddCell(HeaderCell("Completed By:"));
            table.AddCell(ValueCell("1234"));
            table.AddCell(HeaderCell("Date:"));
            table.AddCell(ValueCell("1234"));

            //  2nd row
            table.AddCell(HeaderCell("Work Area:"));
            table.AddCell(ValueCell("1234"));
            table.AddCell(HeaderCell("Job Description:"));
            cell = ValueCell("1234");
            cell.Colspan = 3;
            table.AddCell(cell);

            //  3rd row
            table.AddCell(HeaderCell("Supervisor:"));
            table.AddCell(ValueCell("1234"));
            table.AddCell(HeaderCell("Inspector:"));
            table.AddCell(ValueCell("1234"));
            table.AddCell(HeaderCell("Type:"));
            table.AddCell(ValueCell("1234"));

            /*
                        table.AddCell("Row 2, Col 1");
                        table.AddCell("Row 2, Col 1");
                        table.AddCell("Row 2, Col 1");

                        table.AddCell("Row 3, Col 1");
                        cell = new PdfPCell(new Phrase("Row 3, Col 2 and Col3"));
                        cell.Colspan = 2;
                        table.AddCell(cell);

                        cell = new PdfPCell(new Phrase("Row 4, Col 1 and Col2"));
                        cell.Colspan = 2;
                        table.AddCell(cell);
                        table.AddCell("Row 4, Col 3");
            */

            // Creating some space before displaying the table
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));
            document.Add(table);

            /*//  Table showing summary of the Site Inspection
            table = new PdfPTable(2);
            table.TotalWidth = 500f;
            table.LockedWidth = true;
            table.SetWidths(new float[] { 0.3f, 0.7f });

            color = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#A9A9A9"));
            DrawLine(writer, 25f, document.Top - 79f, document.PageSize.Width - 25f, document.Top - 79f, BaseColor.BLACK);
            DrawLine(writer, 25f, document.Top - 80f, document.PageSize.Width - 25f, document.Top - 80f, BaseColor.BLACK);
            document.Add(table);


            //  Add a simple and wellknown phrase to the document in a flow layout manner  
            document.Add(new Header("Health, Safety, Quality and Environmental Site Inspection"));*/

            // Conclude 
            document.Close();
            writer.Close(); 
            fs.Close();


            /*protected void GenerateReport(object sender, EventArgs e)
            {
                //DataRow dr = GetData("SELECT * FROM SiteInspections ").Rows[0]; ;
                Document document = new Document(PageSize.A4, 88f, 88f, 10f, 10f);
                Font NormalFont = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);
                using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                    Phrase phrase = null;
                    PdfPCell cell = null;
                    PdfPTable table = null;
                    BaseColor color = null;

                    document.Open();

                    //Header Table
                    table = new PdfPTable(2);
                    table.TotalWidth = 500f;
                    table.LockedWidth = true;
                    table.SetWidths(new float[] { 0.3f, 0.7f });


                    //Separater Line
                    color = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#A9A9A9"));
                    DrawLine(writer, 25f, document.Top - 79f, document.PageSize.Width - 25f, document.Top - 79f, BaseColor.BLACK);
                    DrawLine(writer, 25f, document.Top - 80f, document.PageSize.Width - 25f, document.Top - 80f, BaseColor.BLACK);
                    document.Add(table);

                    table = new PdfPTable(2);
                    table.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.SetWidths(new float[] { 0.3f, 1f });
                    table.SpacingBefore = 20f;

                    //Employee Details
                    cell = PhraseCell(new Phrase("Employee Record", FontFactory.GetFont("Arial", 12, Font.UNDERLINE, BaseColor.BLACK)), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    cell.PaddingBottom = 30f;
                    table.AddCell(cell);

                    *//*//Photo
                    cell = ImageCell(string.Format("~/photos/{0}.jpg", dr["EmployeeId"]), 25f, PdfPCell.ALIGN_CENTER);
                    table.AddCell(cell);*//*

                    //Name
                    phrase = new Phrase();
                    phrase.Add(new Chunk(dr["TitleOfCourtesy"] + " " + dr["FirstName"] + " " + dr["LastName"] + "\n", FontFactory.GetFont("Arial", 10, Font.BOLD, Color.BLACK)));
                    phrase.Add(new Chunk("(" + dr["Title"].ToString() + ")", FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)));
                    cell = PhraseCell(phrase, PdfPCell.ALIGN_LEFT);
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    document.Add(table);

                    DrawLine(writer, 160f, 80f, 160f, 690f, BaseColor.BLACK);
                    DrawLine(writer, 115f, document.Top - 200f, document.PageSize.Width - 100f, document.Top - 200f, BaseColor.BLACK);

                    table = new PdfPTable(2);
                    table.SetWidths(new float[] { 0.5f, 2f });
                    table.TotalWidth = 340f;
                    table.LockedWidth = true;
                    table.SpacingBefore = 20f;
                    table.HorizontalAlignment = Element.ALIGN_RIGHT;


                    //Addtional Information
                    table.AddCell(PhraseCell(new Phrase("Addtional Information:", FontFactory.GetFont("Arial", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    table.AddCell(PhraseCell(new Phrase(dr["Notes"].ToString(), FontFactory.GetFont("Arial", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_JUSTIFIED));
                    document.Add(table);
                    document.Close();
                    byte[] bytes = memoryStream.ToArray();
                    memoryStream.Close();
                    Response.Clear();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("Content-Disposition", "attachment; filename=Employee.pdf");
                    Response.ContentType = "application/pdf";
                    Response.Buffer = true;
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.BinaryWrite(bytes);
                    Response.End();
                    Response.Close();
                }
            }

            private static void DrawLine(PdfWriter writer, float x1, float y1, float x2, float y2, BaseColor color)
            {
                PdfContentByte contentByte = writer.DirectContent;
                contentByte.SetColorStroke(color);
                contentByte.MoveTo(x1, y1);
                contentByte.LineTo(x2, y2);
                contentByte.Stroke();
            }
            private static PdfPCell PhraseCell(Phrase phrase, int align)
            {
                PdfPCell cell = new PdfPCell(phrase);
                cell.BorderColor = BaseColor.WHITE;
                cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
                cell.HorizontalAlignment = align;
                cell.PaddingBottom = 2f;
                cell.PaddingTop = 0f;
                return cell;
            }
            private static PdfPCell ImageCell(string path, float scale, int align)
            {
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(HttpContext.Current.Server.MapPath(path));
                image.ScalePercent(scale);
                PdfPCell cell = new PdfPCell(image);
                cell.BorderColor = BaseColor.WHITE;
                cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
                cell.HorizontalAlignment = align;
                cell.PaddingBottom = 0f;
                cell.PaddingTop = 0f;
                return cell;
            }*/

            
        }
        private static PdfPCell HeaderCell(string title)
        {
            PdfPCell cell = new PdfPCell(new Phrase(title, FontFactory.GetFont("Arial", 12, Font.BOLD, BaseColor.BLACK)));
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.PaddingBottom = 7f;
            cell.PaddingTop = 7f;
            return cell;
        }
        private static PdfPCell ValueCell(string value)
        {
            PdfPCell cell = new PdfPCell(new Phrase(value, FontFactory.GetFont("Arial", 10, Font.NORMAL, BaseColor.BLACK)));
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.PaddingBottom = 7f;
            cell.PaddingTop = 7f;
            return cell;
        }
        private static void DrawLine(PdfWriter writer, float x1, float y1, float x2, float y2, BaseColor color)
        {
            PdfContentByte contentByte = writer.DirectContent;
            contentByte.SetColorStroke(color);
            contentByte.MoveTo(x1, y1);
            contentByte.LineTo(x2, y2);
            contentByte.Stroke();
        }
    }
}
