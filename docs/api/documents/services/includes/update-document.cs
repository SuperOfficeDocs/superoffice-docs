using SuperOffice;
using SuperOffice.CRM.Services;
using System.IO;

//  The ID of the document to be updated
private void UpdateDocument(int documentId)
{
  // Create an IDocumentAgent object and retrieve a document
  using(DocumentAgent agent = new DocumentAgent())
  {
    DocumentEntity documentEntityExisting = agent.GetDocumentEntity(documentId);
    // Check if the document exists
    if (documentEntityExisting != null)
    {
      // Generate the file name for the downloaded document
      string extentionOfOriginalDocument = Path.GetExtension(documentEntityExisting.Name);
      string fileName = "tempFile" + extentionOfOriginalDocument;

      // Download the document to the temporary folder
      Stream originalDocumentStream = agent.GetDocumentStream(documentId);
      agent.CreateTempFile(fileName, originalDocumentStream);

      // Close and dispose the stream
      originalDocumentStream.Close();
      originalDocumentStream.Dispose();

      // Now the file is ready to be modified....
      // Read the path for the temporary folder from the config file
      string tempFilePath = Path.Combine(SuperOffice.Configuration.ConfigFile.Documents.TemporaryPath,
          SoContext.CurrentPrincipal != null ? SoContext.CurrentPrincipal.Associate : "ALL");

      // Full path for the downloaded document
      string fullPath = Path.Combine(tempFilePath.Replace("\\\\", "\\"), fileName);

      // Check if the temporary document exists
      if (File.Exists(fullPath))
      {
          // Assuming the user has modified the temporary file...
          // Get the file stream for the temporary local file
          Stream tempStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
          agent.SetDocumentStream(documentEntityExisting, tempStream, true);
      }
    }
  }
}