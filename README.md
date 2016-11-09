# Ping-Check

A small simple display to ping a google IP address periodically. Useful for tracking if you're connected to the internet, experiencing any bandwidth issues, etc. 

---

### Demo

![](http://i.imgur.com/HYeOCg0.gif)

---
  
### Build & Run
**Requirements:** Visual Studio 2015 and/or C# 6.0 Roslyn Compiler  
**Optional:** Devenv (Visual Studio 2015) on PATH   

```
git clone https://github.com/dukemiller/ping-check.git 
cd ping-check
```

**Building with Devenv (CLI):** ```devenv ping-check.sln /Build```  
**Building with Visual Studio:**  Open (ctrl-shift-o) "ping-check.sln", Build Solution (ctrl-shift-b)

A "ping-check.exe" artifact will be created in the parent ping-check folder.