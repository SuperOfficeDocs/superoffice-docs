using SuperOffice.CD.DSL.V1.StepModel;
using System.Collections.Generic;
namespace SuperOffice.DevNetCddLib.DictionarySteps
{
  [Dictionary("DevNetChat", 1, ReleaseState.Released)]
  public class ChatRoom1 : DictionaryStep    
  {
    public override void Structure()
    {
      CreateTable("DN_ChatRoom", "Contains chatroom settings")
        .TableProperties.Replication(ReplicationFlags.Down | ReplicationFlags.Up | ReplicationFlags.Prototype)
        .TableProperties.CodeGeneration(MDOFlags.None, HDBFlags.None, UdefFlags.None, SentryFlags.None)
        .AddString("Name", "Name of the chatroom", 75, true)
        .AddString("Topic", "Description of room content", 255, false)
        .AddEnum<DNRoomStatus>("RoomStatus", "Determines if chat room is open or closed")
        ;

    /// <summary>
    /// Return the hard-coded list of standard IMP files for a new 8.1 installation;
    /// File is loaded from embedded resources in the DLL.
    /// </summary>
    /// <returns>I_ChatRoom.imp</returns>
    public override List<string> ImpFileNames()
    {
      // these are the .IMP files
      return new List<string>
      {
        @"I_ChatRoom.imp",
      };
    }
  
  [DbEnum("Value for field 'RoomStatus' in table 'DN_ChatRoom'.", Layer.Core)]
  public enum DNRoomStatus : short
  {
    [DbEnumMember("Set chat room status to closed.")]
    Closed = 0,
    [DbEnumMember("Set chat room status to open")]
    Open = 1,
  }
}