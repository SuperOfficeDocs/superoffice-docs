public override void CustomPriming()
{
  var utcNow = DateTime.UtcNow;
  var never = DateTime.MinValue;
  var nextIdValue = GetNextId("abc");
  ExecuteSql(@"INSERT INTO { abc} (
    { abc.abc_id},
    { abc.xyz},
    { abc.registered},
    { abc.registered_associate_id},
    { abc.updated},
    { abc.updated_associate_id},
    { abc.updatedCount}
    ) VALUES (
    { @id},
    { @xyz},
    { @registered},
    0,
    { @updated},
    0,
    0
    )",
    new
    {
      id = nextIdValue,
      xyz = "A String",
      registered = utcNow,
      updated = never
    });
}