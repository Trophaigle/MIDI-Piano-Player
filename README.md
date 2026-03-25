# MIDI-Piano-Player

A Unity package that plays MIDI files visually on a keyboard using DryWetMidi.

> ⚠️ This is an early version of the package and may be improved over time.
> ⚠️ Note: It seems that, for reasons I don’t yet understand, the MIDI playback tempo may be slightly faster than the original audio track. This still needs further testing.

If you notice this issue or manage to identify or fix the bug, please feel free to open an issue or contact me. Any feedback is greatly appreciated.

## 🎬 Demo

https://private-user-images.githubusercontent.com/153461032/569129490-d298070f-d561-4cb9-912f-cf7f12597395.mp4

## ✨ Features

- 🎼 Read MIDI files
- 🎹 Visual keyboard playback
- ⏱️ Accurate timing
- 🧩 Easy integration
- 🎬 Sample scene included

---

## 📦 Installation

### Via Unity Package Manager (Git URL)

1. Open Unity
2. Go to **Window > Package Manager**
3. Click **+ > Add package from Git URL**
4. Enter: (github repos .git)

---

## 🚀 Quick Start

1. Import the package
2. Open the sample scene:

Samples > BasicExample

3. Press Play
→ The keyboard will automatically play the MIDI file

---

## 🎮 Usage

### 1. Create Music Data (Scriptable Object)

- Add the `MIDIAssetBuilder` component to a GameObject
- Click **"Generate MIDI DATA"**
- A Scriptable Object will be created in: Assets/Midi

---

### 2. Setup the Piano Player

- Add the `MIDIPianoPlayer` component to your keyboard GameObject
- Assign:
  - Black keys parent
  - White keys parent
- Click **"Auto Assign Keys and Configuration"**
- Provide a MIDI file:
  - Use a `TextAsset`
  - Rename your `.mid` file to `.bytes`

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

