AppModel GetDataFromSuperOffice(string baseUrl, string accessToken)
{
  var model = new AppModel();
  model.BaseUrl = baseUrl;
  model.AccessToken = accessToken;
  _client.BaseUrl = new Uri(baseUrl);
  _client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", accessToken));

  // We don't want XML but JSON response, so force JSON serializer
  _client.ClearHandlers();
  _client.AddHandler("application/json", new RestSharp.Deserializers.JsonDeserializer());
  var request = new RestRequest("v1/Contact", Method.GET);

  // request.AddParameter("$filter", "registeredDate thisYear");
  request.AddParameter("$select", "contactId,nameDepartment,category,business,number,registeredDate");
  var response = _client.Execute<ODataResponse>(request);

  if (response.IsSuccessful)
  {
      model.Contacts = response.Data.value.ToArray();
  }
  else
  {
      model.Error = response.ErrorMessage;
  }
  return model;
}