# D3PDA

This started as a UI themed after the PDA in Doom 3 and evolved from there into something very unique. This UI utilizes a few tricks that you don't see in other UIs to achieve it's unique file structure and layout features. This UI grew to such complexity that I wrote an overly simple generator program to handle generating the variations of files that only differ in what data they convey. 

### What's included in the UI
* An almost complete re-skin of the default templates.
* Player window with an integrate stat sub-window.
* Group window with default key labels and gauges that reflow when mana or endurance are enabled/disabled.
* Spell Casting window with tinted spell slots, spell names, integrated casting gauge, and self adjust based on how many spell gems your character has unlocked.
* Target and Target's Target window with a target's buffs sub-window and hate displayed as a thin gauge over target's HP.
* Extended target window with slim gauges to allow more targets to be viewable in a smaller vertical footprint.
* Task overlay window that fits the theme of the UI.
* Task window reworked to flow better with smaller size.
* Task selection window reworked to flow better with smaller size.
* Combat ability (a.k.a. discipline) window that is a mirror of the spell casting window.
* Advanced loot window with some adjustments to border utilization and removal of item backgrounds.
* EQ button window with smaller buttons that reflow based on resizing.
* Containers with significantly smaller icons.
* Modified chat window to solve template issues and slightly slim down the tab heights. Subject to change more at a later date.
* A reworked overseer window that can fit in a smaller area than the default.
* Buff and Short Duration Buff windows with numbers displayed behind the buff icons.
* A compact bandolier window.
* A variety of other tweaks to address appearance problems as I find them.

### About the file structure
* The usual EQUI_WindowName.xml files are being utilized as compositors to assemble the window from much more granular files. Think of them as per-window EQUI.xml files with how I'm treating them. You will also sometimes find notes in them like in EQUI_TaskOverlayWnd.xml where I used an emulator to map out what it was doing in memory.
* Folders are present for any windows that are composited, these folders as expected contain the files that make up their given window. The exception to this are the animations, assets, generator, and templates folders which have more specific purposes implied by their names.
* Inside each window's folder is a file by the name of _scene.xml, this file serves as a scene graph for the respective window and should be your starting point if you look through a window's XML code.

### Generator Folder:
* The generator is used to generate duplicate items that have different names and EQ types. It just performs a bunch of string replacements with a little bit of regex to isolate more complex things. This is a C# program that will regenerate the contents of the ext_target_window, player_window, group_window, spell_window, and status_window folders. This will be extended to other windows and elements as layout details are modified.
* The source for generating those files is found in the generators/templates folder, it will use those files as a template for similar files.
* Not a universal drop-in file solution. It's all coded to recognize the terms used in my files which may or may not match others, mostly this is for adjusting layout and mirroring changes to all related elements. There is no reason to use it as an ordinary user and it is safe to delete the 'generator' folder if you want.
* Some elements utilize a typing pattern which consist of bracketted syntax to determine what should be inserted in it's place. An indexer can be access via [i] syntax and offsets on the indexer applied with addition [i+1]. [EQLabelType.GroupMember[i]HPPercent] for example will access GroupMember1HpPercent through GroupMember5HpPercent in the EQTypes associated with labels. You can look through EQLabelType.cs and EQGaugeType.cs to see the complete listing for what is recognized.
* Your are free to modify and distribute the source as you see fit. I do not recommend it as it is very rough and only as complex as I needed it to be.
