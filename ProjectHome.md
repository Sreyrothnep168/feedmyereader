feedmyereader provides tools that may be used for creating epub files.

covergen.exe

generates a new 600x800 px jpeg file as epub cover with some text replaced from a template jpeg file. This tool could be used in scripts if covers with different text are needed. Created with Visual Basic 2008 Express. Requires .NET 2.0 runfiles.

Usage:

covergen.exe "c:\files\cover.jpg" "c:\files\cover001.jpg" "Demo – Introduction" "54" "566" "Arial" "36"

Parameters:

Input = full path of cover template file

Output = full path of generated new cover file

Text = text to be added on cover template file

X = left coordinate of text to be added on cover template file

Y = top oordinate of text to be added on cover template file

Font = font name of text to be added on cover template file

FontSize = font size of text to be added on cover template file