# 
# Generate HTML sitemaps from sitemap.xml

pwd
# give us write permissions to build output folder
chmod a+rw ./_site
chown runner:docker ./_site
ls -l
cd _site
pwd
ls -l

echo "<title>Learn english</title>" > learn-en.html
echo "<title>Learn norsk</title>" > learn-no.html
echo "<title>Learn svensk</title>" > learn-sv.html
echo "<title>Learn dansk</title>" > learn-da.html
echo "<title>Learn dutch</title>" > learn-nl.html
echo "<title>Learn german</title>" > learn-de.html

cat sitemap.xml | grep "loc" | grep "/learn/" | grep "/en/" | sed -e 's|<loc>\([^<]*\)</loc>|<a href="\1">\1</a><br>|g' >> learn-en.html
cat sitemap.xml | grep "loc" | grep "/learn/" | grep "/no/" | sed -e 's|<loc>\([^<]*\)</loc>|<a href="\1">\1</a><br>|g' >> learn-no.html
cat sitemap.xml | grep "loc" | grep "/learn/" | grep "/sv/" | sed -e 's|<loc>\([^<]*\)</loc>|<a href="\1">\1</a><br>|g' >> learn-sv.html
cat sitemap.xml | grep "loc" | grep "/learn/" | grep "/da/" | sed -e 's|<loc>\([^<]*\)</loc>|<a href="\1">\1</a><br>|g' >> learn-da.html
cat sitemap.xml | grep "loc" | grep "/learn/" | grep "/nl/" | sed -e 's|<loc>\([^<]*\)</loc>|<a href="\1">\1</a><br>|g' >> learn-nl.html
cat sitemap.xml | grep "loc" | grep "/learn/" | grep "/de/" | sed -e 's|<loc>\([^<]*\)</loc>|<a href="\1">\1</a><br>|g' >> learn-de.html

pwd
ls -l learn*.html
cd ..
