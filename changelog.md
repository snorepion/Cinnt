1.0.0.0
======

Additional settings:

- Maximum number of random letters to generate

- Alphabet bank for generating letters
	
Additional features:

- Hash generation

- Redesigned UI (again)

- Keyboard shortcuts

- One single argument text box for all functions (see help.txt for a list of commands and their arguments)

- Better Unicode support

- Unicode character picker (implementing Fabien Barbier's UnicodeInformation .NET library - see https://github.com/GoldenCrystal/NetUnicodeInfo)
	
Removed features:

- Garble (useless)

- Anagram folded into Shuffle (simpler)
	
Minor changes:

- Increased default size of random letters in memory to 512 MB (assuming 1 char = 1 byte)

- Added extra comments to code
	
- Code simplifications/optimizations

- Organized code

- Allow specific indexing for letter removal

0.4.0.2
======

Various bugfixes

Settings dialog fix

Color setting for status strip

0.4.0.1
======

Fixed bug in Shuffle and Swap

Increased efficiency and decreased memory taken up by Sort

0.4.0 
======

Fixed extremely inefficient subtraction process

UI overhaul

Added settings window and UI color & font customization

Main text box now uses RTF in order to support coloring for regex and find

Restriction added on Add Random Letters so that you can't generate more than 100 MB of random letters at a time.

New functions: 

- Sort alphabetically & numerically, list based on chosen character

- Shuffle a list of words, numbers, or anything

- Reverse list

- Find (regex supported!)

- Experimental revert: undo last function performed (different from basic undo)

0.3.1
======

More accurate word and paragraph count

Controls now scale to fit form

Auto-indent bug fixed

0.3.0
======

New icon

New functions:

- Auto-indent

- Anagram

- Reverse order

0.2.1
======

Fixed Add Random Letters bug

0.2.0
======

Initial release