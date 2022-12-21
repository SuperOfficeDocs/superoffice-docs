public override void Structure()
{
  CreateTable("Movie", "Movie table for movie buffs")
    .AddString("Name", "English name of the movie", 255, notNull: true)
    .AddString("Description", "Description of the movie", 255, notNull: false)
    .AddBool("Rated", "Has this movie been rated?")
    .AddBlob("MoviePreviewImage", "Compressed image string", notNull: false);

  ModifyTable("Movie")
    .AddString("Genres", "The style or category of the movie ", 255)
    .AddInt("Rating", "The rating for this movie");

  ModifyTable("Movie")
    .ModifyField("Description", maxLength: 1024);

  DropTable("Movie");
}