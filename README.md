# RuntimeSaveLoadTilemap
A small example of how to manipulate tilemaps in unity at runtime, saving that state and fetching it in the editor.

- Attach script to gameobject with a tilemap on it.
- Place the editor version in an editor folder
- Create the scriptableObject-buffer through the context menu and attach it to the monobehaviour
- Go nuts on tilemaps at runtime, save it, watch everything disapear when exiting playmode, feel happy again when everything appears again upon loading.
