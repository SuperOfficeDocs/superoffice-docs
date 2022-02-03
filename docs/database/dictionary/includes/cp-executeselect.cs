public override List<string> ImpFileNames()
{
  var abcData = ExecuteSelect(@"SELECT {abc.abc_id} FROM {abc}");
  if (abcData.Rows.Count == 0)
  {
    return new List<string>
    {
       @"abc.imp"
    };
  }
  else
    return new List<string>();
}