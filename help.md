<!--
************************************************************
  Here is Help file source.
  Refer in right web browser preview. =>
************************************************************
-->

<div id='title'>&nbsp;</div>    

Introduction
=====

"MarkDown#Editor" is lightweight text-editor to work on Windows, in Markdown syntax.

This application is 2 pane editor that have text editor in left side window, and previewing in web browser of right side window. You edit in text file, and  convert to HTML file or data source easily.

"MarkDown#Editor" is suitable for a simple, or small web page production. Example, you write articles of blog, and you create .MD file that sites such as [GitHub](https://github.com), [reddit](http://www.reddit.com/), [Stack Overflow](http://stackoverflow.com/) and [SourceForge](http://sourceforge.net/) use.

And so, <a href="http://michelf.ca/projects/php-markdown/extra/" target="_blank" class="external">Markdown Extra</a> is supported. You can edit and convert &gt;table&lt; tag and &gt;dl&lt; tag to HTML files easily.

This application is open source software. You can download and use for free at all, including the source code for both commercial and personal.

Check the information for latest version, source codes and so on in my site.
My site is...

HIBARA.ORG   
[http://hibara.org](http://hibara.org)

Latest source code is hosted on GitHub.
[https://github.com/hibara/MarkDownSharpEditor](https://github.com/hibara/MarkDownSharpEditor)  
* Welcom to folk this, and pull request.

## The Contents of this help.
* [Environment to do](#environment)
* [About Markdown](#about)
* [How to use](#use)
* [The begining of development](#beginning)
* [Developed environment](#development)
* [Copyrights](#copyright)
* [License](#license)
* [Support](#support)
* [Upcoming](#upcoming)
* [Version history](#history)



<a name="environment"></a>
#Environment to do

Windows XP/Vista/7/8 32bit or 64bit PC
Required .NET Framework 4.0 or later.

If your PC is not installed, ".NET Framework 4.0" is able to download and installed from Microsoft web page for free.

Microsoft .NET Framework 4 ( Web installer )    
<a href="http://www.microsoft.com/ja-jp/download/details.aspx?id=17851" target="_blank">
http://www.microsoft.com/ja-jp/download/details.aspx?id=17851</a>

**not** Microsoft .NET Framework 4 Client Profile,
Required normal .NET Framework 4.


##Items installed

"MarkDown#Editor" do not use Windows registory basically, except for associating with .MD file in Windows system.

Therefore, this application will save congfig file, help file and sample data in local directory when that is installed.

If you want to uninstall these files, you could use attached uninstaller.
But if you remove manually, There are those files in following directory:

```C:\Users\[UserName]\AppData\Roaming\MarkDownSharpEditor```



<a name="about"></a>
#About Markdown

First, To know about Markdown, it would be <a href="http://ja.wikipedia.org/wiki/Markdown" target="_blank"  class="external">Wikipedia</a>. :)

Next, <a href="http://daringfireball.net/" target="_blank" class="external">Daring Fireball: Markdown</a>: that site is Markdown originally creator's site.

The detail of a spec marking up is written in this site include syntax examples.

Markdown is to write using an easy-to-read, easy-to-write plain text format, then convert it to structurally valid XHTML (or HTML).

I found many text editor about Markdown on Macintosh, but it is not found on Windows, and corresponding of Japanese support. So, I developed this application - "MarkDown#Editor" myself.



<a name="use"></a>
#How to use

Input text strings to left side window on Markdown, then the parsed results will be previewed in right browser window in real time.

Of course, you can output to HTML files, and copy HTML source to Clipboard in one click easily.

And there are a lot of output options, embeded data of CSS file, linking to external files and so on.

There are some buit-in CSS files already in "MarkDown#Editor", but it is sure to be able to add original CSS files yourself.

I think this application do not have many buit-in CSS files. I want to add CSS files gradually, but sample CSS files are everywhere on the Internet. It is a good idea to use them.



##Relative path and Absolute path

Basically, you input relative paths ( ex. image/foo.png ) in left side of text editor window, then this application will find files from base directory of that .MD file you are editing now.

Therefore if you want to see while writing a link to the other files or images, you need to put resource files on the folder.

If you think it is not comfortable, you would upload images to your blog in web site, and you input absolute path in text editor directly.

The following sample is image external linking URL.

![External icon URL](http://hibara.org/software/markdownsharpeditor/img/main_icon_48x48.png)   

As well, your PC connects with Internet if broser preview.

Above image may be not displayed normally without connecting with Internet.



<a name="begining"></a>
#The begining of development

I am developing <a href="http://hibara.org/software/attachecase/"  target="_blank" class="external">"AttacheCase"</a> that is AES encryption tool, then I must have rewritten help files in HTML format.

However, there is not good Markdown editor almost on Windows and Japanese support.

I found like these applications in Macintosh, but it is incorrect to wirte Windows help files on Mac? :)

Therefore I must have developed this application.



<a name="development"></a>
#Developed environment

I use VisualStudio C# 2010 Express.

Markdown parser engine is C# class library implemented that is BSD License in the following item of "Copyright". 

Of course, those copyrights are written in this application, too.

If you are interested in Markdown and development, you could visit those web pages in next item.



<a name="copyright"></a>
#Copyrights

## Markdown  -  A text-to-HTML conversion tool for web writers   
Copyright (c) 2004 John Gruber   
[http://daringfireball.net/projects/markdown/](http://daringfireball.net/projects/markdown/)   

## MarkdownDeep
[http://www.toptensoftware.com/markdowndeep/](http://www.toptensoftware.com/markdowndeep/)
Copyright 2010-2011 Topten Software

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this product except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.



<a name="license"></a>
#License

GPLv3
https://www.gnu.org/licenses/gpl-3.0.html

However, for other libraries, please follow the license of each.

If you are according to this license, you can download and use for free at all, including the source codes for both commercial and personal use.

Use of the this software, modify, redistribute, such as sale, please follow the above licenses. Please keep from contact as much as possible to me on this matter.



<a name="support"></a>
#Support

I am always busy...so, returns are very hard, especially FAQ and so on.

However demands of improvement, bug reports and feedbacks is welcome.

I have been accepted at the following URL.
https://github.com/hibara/MarkDownSharpEditor/issues

Also accept e-mail on the other hand, but I do not response quickly...   
m@hibara.org



<a name="upcoming"></a>
#Upcoming

There are plenty of features for improvement. While listen to opinions of users, I improve quality of this applicaiton.

The first and foremost, I want to improve the performance of the previewing speed. And put html files on server int the future. I think it is difficult it comes to the development phase...



<a name="history"></a>
#Version history

##ver.1.2.2.0　　2013/06/27

* Inproved to be able to register by drag and drop the CSS file in setting panel. In addition, to be able multi-select files in open file dialog.

* Fixed problem that the process was killed when this application exits before the browser drawing will be done.

* Fixed problem that the editor window is blank when you select "Open File" menu, that was "New File" command...

* Fixed that problem that the background color of the "Table" has not been able to save successfully.

* Fixed that in the initial start-up after installation, CSS file which do not intend to has been applied when you open a Japanese help file.

* Improved syntax highlighter processing performance, and fixed an error in the regular expression "Backslash Escape" and so on. (*1)

* Fixed do not open the help file in the browser preview, and a had a problem in various ways to the display processing. (*2)

	*1&2: Thanks to [Yasami](https://github.com/Yasami) for the pull requests! 


##ver.1.2.1.0　　2013/06/18

* Added to check for latest version release.

* Fixed some dialog did not show a message right ( by localization ).

* Fixed starting to edit new file cause a crash.

* Fixed the problem that had been when it reaches the end of the text while editing, it crashes as well.

* Fixed that the problems IME(FEP) would be determined a conversion during editing unintentionally sometimes ( when you are running in a Japanese environment ).

* Fixed the problem that had gone to first start as an English version, when you run the installer in a Japanese environment.


##ver.1.2.0.0　　2013/06/09

* Added Markdown Extra mode.

* Localized and create English version.

* Syntax highlighting processing of editor side became so heavy, so improved that it is edited before and after to apply.

* The browser preview was treated with BackgroundWorker ( that processing in other thread).

* Fixed error occured when changing "Interval time of previewing" options.


##ver.1.1.5.0　　2013/03/07

* Fixed problems where the error occurred when an attempt is made scroll in the editing window, when you start editing in Untitled and "New".

* Fixed that you are doing the "New", and it would continue to create the temporary file "Untitled [0001]. md" in local path.

* Fiexed when number of the editing history( have a set of md file and css file) of internally exceeds limit of 20, error has occurred in the application exits.

* Fixed when you select "Replace All" in the string search-and-replace, there is that it would continue to enter the replacement string and then runaways.

* Fixed problems such as the .MD file name that contains a space, starting to associated with did not work well.

* Fixed the problem that debug mode is activated behavior set in the "General" and "Interval time of browser preview" option. It had become input form of the text box directly.

* Fixed that error occure rarely when you are finished "MarkDown#Editor" at the timing the browser preview is working. ( Application was terminated after stopping the thread to go to preview in browser. )

* Tweak the scroll behavior of the tex editor.


##ver.1.1.4.0　　2013/01/30

* Fixed problem that it had been crashed at processing to stop the click sound when updating the browser window.

* Added settings for foreground and background colors of the window in general. (There had been the settings internally, but I had forgotten to make the UI ...)


##ver.1.1.3.0　　2012/12/25

* Added Search and Replace.

* Improved when the application was "minimized", or "maximized" the window, it did not save the form position and size exactly.

* Redesign toolbar icon graphic of "Copy HTML source to Clipboard" to make a distinct of "Output HTML file" icon.

* Stopped mouse click sound at the time of updating a web browser.

* Fixed the problem that pop-up menu of selecting a CSS file in status bar has been displayed when no the built-in CSS files registered.


##ver.1.1.2.0　　2012/12/12

* Added the menu function "View jump list to the Headings symbol".

* Fixed problem that the regular expression of the syntax highlighter could not be interpreted correctly "Heading sign (h1 ~ h6)" on Markdown in some cases.


##ver.1.1.1.0　　2012/12/11

* Fixed that fatal error occured when you begin to edit the file in the New.

* Fixed the problem that some of the contents were not display marker.


* Fixed some of the contents was editing in text editor that were not displayed in the browser preview becasue of fixing around the marker preview in previous version.


##ver.1.1.0.0　　2012/12/07

* Commit to [pull request](https://github.com/hibara/MarkDownSharpEditor/pull/1) on GitHub, that could not changed text font in editor. Thanks! [alg](https://github.com/alg0002).

* In addition, font without Japanese support can not be displayed in Japanese, and The editing text was broken ( could not restored ). Added font format chages to undo buffer, and restored in "Undo" command.

* Fixed "openFileDialog1" was the default file name in the dialog that opens the file, 

* Fixed the file currently being edited, modified to open as the initial directory.

* Fixed that Garbage display is gradually increased to the browser side from the state of New editing, when you edit the header symbol. 

* Fixed when a file is loaded in during editing othe file, this application would crash with "Undo" command.(*1)

* Improved to keep the display position (scroll bar position) to updated browser preview when editing the contents.(*2)

    （*1, *2 thanks [mattn](https://github.com/mattn)! to provide sample )

* Improved text editor, a follow-up scroll around the browser preview. In addition, Tuned the process of syntax highlighter and preview in editing.
(I think heavy editing were reduced a little... )


##ver.1.0.9.0　　2012/10/31

* Rewrited the help files according as the open source, and modified source code ( where it has nothing to do directly, such as comment-out mainly).


##ver.1.0.8.0　　2012/10/16

* Fixed that the default CSS could not be added and viewed in the pop-up menu when you add a new CSS file.

* Fixed the specification of Markdown in "List" of "to allow up to three spaces in front of the list symbol" and "**one or more **spaces or tabs after the sign" that has not been reflected in the syntax highlighting.

* Fixed the problem that did not correspond to the syntax highlighting starts with a number of "list".

* Fixed the problem of the "list" is to mix during editing, marks of editing may not be displayed correctly, or the preview window did not follow to scroll.


##ver.1.0.7.0　　2012/10/02

* Fixed error that <body> tag did not include in the HTML source to output.

* Improved to synchronize scrolling between text editor side and the browser preview window.

* Improved to suppress the flicker slightly in browser whenever the cursor text editor side is moved. Omitted to paint at intervals, moreover marking preview at diffrent time.

* Fixed display encoding of the browser page loaded has not been correctly reflected.

* Fixed problem that has not been reflected in the main window immediately, when you change the setting.

* Fixed setting of the color editing mark in the browser window is not reflected correctlly.

* Added function of launching the browser which is associated with the HTML files, in the menu and toolbar.

* Adjusted to reduce the number of unnecessary drawing in browser according to create a lag reflected intentionally in the editing.

* Adjusted interval time of preview, and added manual updating in browser without automatic updates.

* Added features that CSS file is setted "default" that have been registered at the top of the built-in CSS file list.

* Fixed the problem of continuing to generate a temporary file, every time you edit in "Untitled" file. On the other hand, ( and therefore, there is the thing that links do not work correctly if you edit still untitled. It has been the specification. ) that do not exported as temporary files edited in the "Untitled".


##ver.1.0.6.0　　2012/09/23

* Fixed the problem that images were loaded and displayed first, when the image specified in the local (relative path image), but it will disappear during editing.

* Fixed the problem entire text has been applied to syntax highlighter when changing the "heading" in the beginning of editor.

* Fixed that the parser of syntax highlighter did not work, when you open a new file.

* Fixed the error has occurred, if you copy and paste text with format.

* Fixed both function of Undo and Redo was not working correctly.


##ver.1.0.5.0　　2012/09/18

* Fixed the original font settings will be lost when syntax highlighter processing works.

* Fixed a bug that boot from a associated file did not work.

* Fixed problems that did not open the file when you choose the file path from the "Ropen recently" menu.

* Fixed the syntax highlighter property was not clear in browser, when reload another file in a text editor side.


##ver.1.0.4.0　　2012/09/11

* Implemented a syntax highlighter of editor side, but just, still heavy quite.
However, I tried to put spreading load processing. Let me know if there is incomplete part.

* Adjusted the timing preview of browser, was taken to balance the load and display speed sensitively.

* Added "Update" and "Stop" button in the browser preview window.

* Changed the full path displays on the title of main form.

* Fixed the problem of drag-and-drop files did not work.


##ver.1.0.3.0　　2012/09/08

* Fixed CSS setting panel around, such as crashed when you delete the CSS file, and were not registered, CSS settings were not saved.

* Added on "Back" and "Forward" buttons to the browser display. This application often do not refresh editing history because Update enters many times could affect how the operating speed. ( Browser component navigate and create histories at same time, when you save the file. Then it is possible to go back and forward as often allows. )

* Added a syntax highlighter function of the editor window experimentally, because I want to see the operating speed. First, changed only background color of blank spaces * 2 ( = line breaks) of the "end of the line" that it is hard to see almost.


##ver.1.0.2.0　　2012/09/06

* Fixed the header and footer is inserted into the double in "HTML file output" command.

* Fixed that crashed when editing an "Untitled".

* Added to batch process in the current configuration, when you drag and drop together multiple files.


##ver.1.0.1.0　　2012/09/05

* Fixed the problem that had been crashed in "Copy HTML source to Clipboard".

* Improved to reduce speaking click sound frequently to refresh browser. That is 
re-drawed the contents as much as possible without calling the "Navigate()"  function each time.

* Fixed the problem of "Update" state is not released, however saved the file. ( Notice window that has changed was displayed when you close the file)


##ver.1.0.0.0　　2012/09/02

* Released.



---
Copyright&copy; 2012-2013 M.Hibara, All rights Reserved. 
