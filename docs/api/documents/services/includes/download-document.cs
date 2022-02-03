
private void DownloadDocument(int documentId)
{
  // create an DocumentAgent object and retrieve a document
  using(DocumentAgent agent = new DocumentAgent())
  {
    DocumentEntity documentEntityExisting = agent.GetDocumentEntity(documentId);

    // check if the document exists
    if (documentEntityExisting != null)
    { 
      // generate the file name for the downloaded document
      string extentionOfOriginalDocument = Path.GetExtension(documentEntityExisting.Name);
      string fileName = "tempFile" + extentionOfOriginalDocument;

      // download the document to the temporary folder
      agent.CreateTempFile(fileName, agent.GetDocumentStream(documentEntityExisting));

      // read the path for the temporary folder from the config file
      string tempFilePath = Path.Combine(SuperOffice.Configuration.ConfigFile.Documents.TemporaryPath, SoContext.CurrentPrincipal != null ? SoContext.CurrentPrincipal.Associate : "ALL");

      // full path for the downloaded document
      string fullPath = Path.Combine(tempFilePath.Replace("\\\\", "\\"), fileName);

      // open the document using the open shell command
      if (File.Exists(fullPath))
      {
        // create a process
        System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

        // pass the file name with extension to open the file
        myProcess.StartInfo.FileName = fullPath;
        myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        myProcess.Start();
      }
      else
      {
        MessageBox.Show("The document has not been downloaded properly.");
      }
    }
    else
    {
      MessageBox.Show("The document you are trying to open does not exist in the server.");
    }
  }
}