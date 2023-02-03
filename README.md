# Brainfuck Converter
A simple GUI for Windows use to convert Extended ASCII to BRAINFUCK code and back.

## BRAINFUCK
Can be converted into from Extended ASCII with currently one default memory setup.
Can be converted to Extended ASCII, with the supported features below, with some limitations also mentioned below.

### Supported
- Supporting loops and the following BRAINFUCK options, `<`, `>`, `+`, `-`, `.`. 
- Manages over- and underflow at 0 and 255 to optimize the BRAINFUCK code.
- Able to use any size of inputted BRAINFUCK memory, up to the C# List max length of 2147483647.

### Unsupported
- Does not yet support moving of cells in BRAINFUCK done with the `,` option.

## Extended ASCII
Extended ASCII differes a bit from machine to machine and coding. But, the main ASCII characters (0-127) are always the same.
As well as character 160-255 are often also the same for every system.

### Supported Characters
```
	

 !"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~ ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ
```

As seen, multiple of the Extended ASCII characters are not visible or undefined with `?`.
This is because they could be operations, line breaks or similar and some of them are simply undefined.
All of these are excluded from the default optimized memory setup, but can always be accessed through the first memory cell.

## Default Memory Setup
The basic default memory setup is split up into nine cells plus the first cell that is used for anything else, making it a total of 10 cells.
The pointer starts at cell 6 and the table below is how all the cells are set up.

#1 | #2 | #3 | #4 | #5 | #6 | #7 | #8 | #9 | #10
--- | --- | --- | --- |--- |--- |--- |--- |--- |---
0 | 176 | 91 | 123 | 60 | 50 | 80 | 110 | 40 | 216

### Extended ASCII groups
The Extended ASCII is grouped into smaller parts of types of characters and ordered by most used in order to reduce the amount of increments and moves.
This table shows where each character falls into the memory cells.

#1 | #2 | #3 | #4 | #5 | #6 | #7 | #8 | #9 | #10
--- | --- | --- | --- |--- |--- |--- |--- |--- |---
Remaining | 160-191 | 91-96 | 123-126 | 58-64 | 48-57 | 65-90 | 97-122 | 32-48 | 192-255

## GUI
The GUI is made using WPF from version 2.0.0 and forward. The first version uses the outdated Windows Forms, but the convertion still works as intended. 
