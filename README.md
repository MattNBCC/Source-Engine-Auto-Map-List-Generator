# Map Cycle Generator

A simple Windows tool for creating **mapcycle text files** from your game’s `.bsp` maps  
(works great for Source / GoldSrc servers and similar games).

The app looks through a folder for all `.bsp` files, removes the `.bsp` part, and saves the list of map names into a text file like `mapcycle.txt`, `gungame.txt`, etc.

---

## What it does

- Searches a folder (and all subfolders) for `.bsp` map files.
- Builds a clean list of map names (without the `.bsp` extension).
- Saves that list into a text file you can use as a mapcycle for your game server.
- Lets you choose from common filenames (like `mapcycle.txt`) or add your own custom one.

---

## How to use

### 1. Find your maps

1. Start the program.
2. Click **Browse**.
3. You’ll be asked:

   > “Would you like to browse in current directory for maps?”

   - Click **Yes** if your maps are in the same folder as the program.
   - Click **No** if you want to choose a different folder (for example, your game’s `maps` folder).

4. The app will scan that folder (and all subfolders) for `.bsp` files and show you a list of map names, one per line.

If something is wrong with the folder or files, you’ll see an error message.

---

### 2. Pick the type of mapcycle file

On the right side, there’s a list of mapcycle file types (for example, `mapcycle.txt`).

1. Click one of the items in that list to choose the filename you want to create.

If nothing is selected, the app will remind you to pick one.

---

### 3. Export the map list

1. Click **Export**.
2. You’ll be asked:

   > “Would you like to export to current program directory?”

   - Click **Yes** to save the file in the same folder as the program.
   - Click **No** to choose a different folder to save into.

3. The app will create a text file with the name you selected and put all of the map names into it (one per line).

You can now use that file as a mapcycle for your game server.

---

### 4. Add your own custom filename (optional)

If you want a different filename (for example, `competitive_cycle.txt`):

1. Click **Custom Add**.
2. Type the name you want (for example: `surf_cycle.txt`) and press **OK**.
3. Your new name will appear in the list of mapcycle types.
4. Select it and export like normal.

---

## Typical example

1. Put the program near your game’s `maps` folder (or just point it there).
2. Click **Browse** → choose the folder with your `.bsp` files.
3. Wait for the map list to appear.
4. Select `mapcycle.txt` (or your custom name) from the list.
5. Click **Export** and choose where to save.
6. Copy the generated file to your game server and use it as your mapcycle.

That’s all you've got to do! No manual typing of map names needed.
