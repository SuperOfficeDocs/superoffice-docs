<%@ Page Language="C#" AutoEventWireup="true" Debug="true"%>
<% Response.ContentType = "text/xml"; %>
<% 
// INPUT: Read parameters we receive from Expander Data Exchange
if (Request.ContentLength > 0)
{
  byte[] buffer = new byte[Request.ContentLength];
  Request.InputStream.Read(buffer, 0, Request.ContentLength);
  System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
  doc.InnerXml = System.Text.Encoding.ASCII.GetString(buffer);
  System.Xml.XmlNode parameters = doc.DocumentElement.ChildNodes[0];
  foreach (System.Xml.XmlElement parameter in parameters.ChildNodes)
  {
    String name = parameter.GetAttribute("name");
    String value = parameter.InnerText;

    // Get parameters here, e.g. if (name == "sql")
  }
}
// OUTPUT: Send output back to Expander Data Exchange
Response.Write("<?xml version='1.0' encoding='ISO-8859-1'?>");
Response.Write("<response version=\"1.1\">\r\n");
Response.Write("  <parameters>\r\n");
Response.Write("  </parameters>\r\n");
Response.Write("  <object>\r\n");
Response.Write("    <string name=\"column.size\">3</string>\r\n");
Response.Write("    <string name=\"column.0\">1</string>\r\n");
Response.Write("    <string name=\"column.1\">SuperHjelms Incorporated</string>\r\n");
Response.Write("    <string name=\"column.2\">+47 90 99 41 48</string>\r\n");
Response.Write("  </object>\r\n");
Response.Write("  <object>\r\n");
Response.Write("    <string name=\"column.size\">3</string>\r\n");
Response.Write("    <string name=\"column.0\">2</string>\r\n");
Response.Write("    <string name=\"column.1\">ACME Software</string>\r\n");
Response.Write("    <string name=\"column.2\">+1 555 428-1234</string>\r\n");
Response.Write("  </object>\r\n");
Response.Write("</response>\r\n");
%>