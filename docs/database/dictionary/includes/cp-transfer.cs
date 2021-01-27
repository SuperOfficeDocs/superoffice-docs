public override void Structure()
{
  ModifyTable("abc")
    .AddString("def", "Descrition", 100, notNull: false)
  ;
}

public override void CustomPriming()
{
  ExecuteSql(@"UPDATE {abc}
    SET {abc.def} = {abc.xyz}, 
      {unogroup.updated } = {@now}",
    new { now = DateTime.Now });
}