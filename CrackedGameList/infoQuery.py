from bs4 import BeautifulSoup
import urllib.request
import collections
import itertools
import re


class AppURLopener(urllib.request.FancyURLopener):
    version = "Mozilla/5.0"

#STUFF FOR CROHASIT

urlopen = AppURLopener()
webContents = urlopen.open('https://crohasit.com/')
webContents = BeautifulSoup(webContents, "html5lib")

titles = []
setTitles = []


cgDates = open("CroGameDates.txt", 'w')
#wcFile = open("CroWebQuery.txt", 'w')
gameInfo = open("CroGameInfo.txt", 'w')
#gameInfo.write("crohasit\n")
#wcFile.write(str(webContents))

spans = webContents.find_all('span', {'class' : 'thetime updated'})
lines = [span.get_text() for span in spans]
#found_dates = []
for line in lines[:10]:
    m = re.search('(\w[a-z]* \d{1,2}, \d{4})', line)
    if m:
        cgDates.write(m.group(1) + "\n")
        #found_dates.append(m.group(1))

for t in webContents.find_all('a'):
    if(str(t.get("title")) != "None" and str(t.get("title")) != "Posts by cro" and str(t.get("title")) != "View all posts in Indie" and str(t.get("title")) != "View all posts in Action" and str(t.get("title")) != "View all posts in FPS" and str(t.get("title")) != "View all posts in Anime" and str(t.get("title")) != "View all posts in Adventure" and str(t.get("title")) != "View all posts in Simulator" and str(t.get("title")) != "View all posts in Open World"):
        titles.append(str(t.get("title")))

seen = set()
for title in titles[:30]:
    if title not in seen:
        gameInfo.write(title + "\n")
        setTitles.append(title)
        seen.add(title)


#wcFile.close()
gameInfo.close()
cgDates.close()
gameInfo = open("CroGameInfo.txt", 'r')
info = gameInfo.read()
info = info.replace("Free Download", "")
gameInfo = open("CroGameInfo.txt", 'w')
gameInfo.write(info)
gameInfo.close()

#STUFF FOR CROHASIT ^^^


#STUFF FOR IGG-GAMES

titles = []
setTitles = []


urlopen = AppURLopener();
webContents = urlopen.open("http://igg-games.com/");
webContents = BeautifulSoup(webContents, "html5lib");

iggDates = open("IGGGameDates.txt", 'w')
#wcFile = open("IGGWebQuery.txt", 'w')
iggGameInfo = open("IGGGameInfo.txt", 'w')

#wcFile.write(str(webContents))

spans = webContents.find_all('span', {'class' : 'ext'})
lines = [span.get_text() for span in spans]
for line in lines:
    m = re.search('(\w[a-z]* \d{1,2}, \d{4})', line)
    if m:
        iggDates.write(m.group(1) + "\n")


for t in webContents.find_all('a'):
    if(str(t.get("title")) != 'None' and str(t.get("title")) != 'Posts by Admin '):
        titles.append(str(t.get("title")))

for title in titles:
    del_perm = re.search('(Permanent Link: .*)', title)
    del_pc = re.search('PC Games', title)
    del_anime = re.search('Anime .*', title)
    del_vis = re.search('Visual Novel .*', title)
    if(del_perm or del_pc or del_anime or del_vis):
        titles.remove(title)
    else:
        iggGameInfo.write(title + "\n")

iggDates.close()
#wcFile.close()
iggGameInfo.close()
iggGameInfo = open("IGGGameInfo.txt", 'r')
info = iggGameInfo.read()
info = info.replace("Free Download", "")
iggGameInfo = open("IGGGameInfo.txt", 'w')
iggGameInfo.write(info)
iggGameInfo.close()
