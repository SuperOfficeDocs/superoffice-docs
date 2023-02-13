using System;

namespace ControlsAndDataHandlers
{
  public class PersonalColorCarrier
  {
    private BasicColor _color;
    private string _name;
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    public BasicColor SelectedColor
    {
      get { return _color; }
      set { _color = value; }
    }
    private DateTime _date;
    public DateTime BirthDate
    {
      get { return _date; }
      set { _date = value; }
    }
  }
  public enum BasicColor
  {
    //These numbers match the field values
    //in the UDLIST table of the SO database
    White = 1,
    Black,
    Grey,
    Blue,
    Green,
    Red,
    Yellow,
    Brown,
    Orange,
    Violet
  }
}