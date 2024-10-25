
public class ActivityData
{
  #region private properties
  string _id;
  string _desciption;
  string _date;
  string _activityType;
  string _projectName;
  #endregion

  //class constructor
  public ActivityData(string activityType, string id, string desciption, string date, string projectName)
  {
    _id = id;
    _desciption=desciption;
    _date=date;
    _activityType = activityType;
    _projectName = projectName;
  }

  # region public class properties

  // activity id
  public string id
  {
    get { return _id; }
    set { _id = value; }
  }

  // the description of the activity
  public string desciption
  {
    get { return _desciption; }
    set { _desciption = value; }
  }

  // the date on which the activity is registered
  public string date
  {
    get { return _date; }
    set { _date = value; }
  }

  // the type of the activity
  public string activityType
  {
    get { return _activityType; }
    set { _activityType = value; }
  }

  // the project name of the activity
  public string projectName
  {
    get { return _projectName; }
    set { _projectName = value; }
  }
  #endregion
}