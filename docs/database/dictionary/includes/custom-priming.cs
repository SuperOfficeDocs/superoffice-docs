public override void CustomPriming()
{
  var utcNow = DateTime.UtcNow;
  var never = DateTime.MinValue;
  ExecuteSql(@"INSERT INTO { abc} (
    { abc.abc_id},
    { abc.xyz},
    { abc.registered},
    { abc.registered_associate_id},
    { abc.updated},
    { abc.updated_associate_id},
    { abc.updatedCount}
    ) VALUES (
    { @abc_id},
    { @xyz},
    { @registered},
    { @registered_associate_id},
    { @updated},
    { @updated_associate_id},
    { @updatedCount}
    )",
    new
    {
      abc_id = 1,
      xyz = "A String",
      registered = utcNow,
      registered_associate_id = 0,
      updated = never,
      updated_associate_id = 0,
      updatedCount = 0
    });
}