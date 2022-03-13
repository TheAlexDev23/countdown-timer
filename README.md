# Countdown Timer


As the name sugests this is a timer that runs on the terminal.

You give it an input in hours minutes and seconds and it runs.

When the time finishes it will produce a "beep".

Screenshot:

![AltText](/Images/screenshot1.png)

# Usage

## Prepartation


If you're on linux, don't forget to run:

```bash
chmod +x countdown-timer-linux
```

## Running

### Abbreaviation 

If you're on windows: `program = countdown-timer-windows.exe`

If you're on linux: `program = ./countdown-timer-linux`

### How to run

```
program [time]
```

#### Example
This will set the timer to run for 1 hour 5 minutes and 4 seconds
```
program 1h5m4s
```
The order doesn't matter:
```
program 5m4s1h
```

More examples

```
program 5s

program 2m3s

program 1h2s

progam 5h2m
```
