protected override void OnStart(string[] args)
{
  timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);

  // set interval to 1 minute (= 60,000 milliseconds)
  // this is for 24 hours
  timer.Interval = 216000000;

  // enabling the timer
  timer.Enabled = true;
}

private void OnElapsedTime(object source, ElapsedEventArgs e)
{
  try
  {
    //this is use to get the UserName from the App Config
    string userName= System.Configuration.ConfigurationManager.AppSettings["UserName"] .ToString();

    //this is use to get the Password from the App Config
    string password = System.Configuration.ConfigurationManager.AppSettings["Password"] .ToString();

    using (newSession = SoSession.Authenticate(userName, password))
    {
      CurrencyUpdater.Currency basecurrencyName;

      //get the base currency ID from the database
      int baseCurrencyId = SuperOffice.CRM.Rows.Util.CurrencyConversionHelper.BaseCurrencyId;
      CurrencyRow currencyRow = CurrencyRow.GetFromIdxCurrencyId(baseCurrencyId);
      basecurrencyName = (Currency)Enum.Parse(typeof(Currency), currencyRow.Name, true);
      Select sqlSelect = S.NewSelect();

      // Create an instance of the CurrencyTableInfo object
      CurrencyTableInfo c1 = TablesInfo.GetCurrencyTableInfo();

      // Set the return fields to All
      sqlSelect.ReturnFields.Add(c1.All);

      //Establishing a Database Connection
      SoConnection myConn = ConnectionFactory.GetConnection();

      //Creating and SoCommand instance and assigning the earlier
      created Select statement

      SoCommand myComm = myConn.CreateCommand();
      myComm.SqlCommand = sqlSelect;

      //open the connection
      myConn.Open();
      SoDataReader myReader = myComm.ExecuteReader();

      //Retrieving the Data from the Reader
      CurrencyRows currencyRows=
      CurrencyRows.GetFromReader(myReader,c1);

      //Closing the Reader and Disposing the session
      myReader.Close();
      foreach (CurrencyRow row in currencyRows)
      {
        //Create an instance of currency converter service
        CurrencyUpdater.CurrencyConvertor cConvertor = new CurrencyUpdater.CurrencyConvertor();
        try
        {
          CurrencyUpdater.Currency currencyName =  (CurrencyUpdater.Currency)Enum.Parse(typeof(CurrencyUpdater.Currency), row.Name, true);

          //Currency rate is given relevant to 1 unit of base currency
          //Invoke ConversionRate()  method from the currency converter service
          double currencyRate = cConvertor.ConversionRate(basecurrencyName, currencyName);

          //Set the rate by multiplying the currencyRate in to units
          //if row.Units=1
          //currencyRate=5.5352
          //then row.Rate=5.5352
          row.Rate = currencyRate* row.Units;

          //Update the currency row with new rate
          row.Save();
        }
        catch (Exception ex)
        {
          System.Diagnostics.Debug.Write(ex.Message);
        }
      }
    }
  }
}

protected override void OnStop()
{
  timer.Enabled = false;
}