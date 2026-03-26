# MIDI-Piano-Player

A Unity package that plays MIDI files visually on a keyboard using [DryWetMidi.](https://github.com/melanchall/drywetmidi)

> ⚠️ This is an early version of the package and may be improved over time.

> ⚠️ Note: It seems that, for reasons I don’t yet understand, the MIDI playback tempo may be slightly faster than the original audio track. This still needs further testing.

## Prerequisites

This package requires **DryWetMIDI** to be installed in your Unity project.  

If you notice this issue or manage to identify or fix the bug, please feel free to open an issue or contact me. Any feedback is greatly appreciated.

## 🎬 Demo (visual and audio)

https://private-user-images.githubusercontent.com/153461032/569129490-d298070f-d561-4cb9-912f-cf7f12597395.mp4

## ✨ Features

- 🎼 Read MIDI files
- 🎹 Visual keyboard playback
- ⏱️ Accurate timing
- 🧩 Easy integration
- 🎬 Sample scene included

---

## 📦 Installation

## Installation

1. Download or clone this repository
2. Copy the `Assets/MIDIPianoPlayer` folder into your Unity project's `Assets` folder
3. Open the DemoScene in `MIDIPianoPlayer/Runtime/DemoScene`

---

## 🎮 Usage

### 1. Create Music Data (Scriptable Object)

- Add the `MIDIAssetBuilder` component to a GameObject
- Provide a MIDI file:
  - Use a `TextAsset`
  - Rename your `.mid` file to `.bytes`
- Click **"Generate MIDI DATA"**
- A Scriptable Object will be created in: Assets/Midi

---

### 2. Setup the Piano Player

- Add the `MIDIPianoPlayer` component to your keyboard GameObject
- Assign:
  - Black keys parent
  - White keys parent
- Click **"Auto Assign Keys and Configuration"**

---
### 3. Control Playback

You can control playback via script:

```csharp
midiPlayer.Play();
midiPlayer.Stop();
```

---

### 4. License

This project is licensed under the MIT License.

