private class ExplicitParams
{
  internal int id;
  string xyz = "A string";
  int zero = 0;
  DateTime utcNow = DateTime.UtcNow;
  DateTime never = DateTime.MinValue;
}

public override void CustomPriming()
{
  var nextIdValue = GetNextId("abc");
  ExecuteSql(@"INSERT INTO { abc } (
    { abc.abc_id },
    { abc.xyz },
    { abc.registered },
    { abc.registered_associate_id },
    { abc.updated },
    { abc.updated_associate_id },
    { abc.updatedCount }
    ) VALUES (
    { @id },
    { @xyz },
    { @utcNow },
    0,
    { @never },
    0,
    0
    )",
    new ExplicitParams
    {
      id = nextIdValue
    });
}