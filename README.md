# CS_FactoryIO
This library is a wrapper around the EngineIO library and can be easily loaded in Python through pythonnet

An example how to use this library from Python:
```
import clr
import sys
import time
from System import Action

sys.path.append(r'C:\Path\to\your\libdir')
clr.AddReference(r'C:\Path\to\your\libdir\Factory')

from Factory import MemoryMap, MemoryType,InputsValueChanged,MemoriesChangedEventArgs

# In my FIO Test-Scene you can find a sensor at address "0"
sensor1 = MemoryMap.Instance.GetBit(0,MemoryType.Input)
print(f"MemoryBit: {sensor1.Value}")

# -- helper method
def memType(mt):
    if mt == 0:
        return 'Memory'
    elif mt == 1:
        return 'Input'
    elif mt == 2:
        return 'Output'
    

def myCallback(args):
    print(f"value changed ")
    for mem in args.MemoriesBit:
        print(f"{memType(mem.MemoryType)} Bit({mem.Address}) value changed to: {mem.Value}")

# -- This is how to create an EventHandler for changing sensor values
# -- In the C# project you can find 6 different EventHandler classes:
# -- InputsValueChanged, InputsNameChanged, OutputsNameChanged, OutputsValueChanged, MemoriesNameChanged, MemoriesValueChanged
# -- They all work the same.. MemoriesChangedEventArgs is the type passed to the callback -> see the EventSample in the factoryio-sdk for more info

InputsValueChanged.RegisterEvent(Action[MemoriesChangedEventArgs](myCallback))

while 1:
    time.sleep(0.016)
    # -- Remember to update or nothing will happen
    MemoryMap.Instance.Update();
  
# -- Remember to dispose at the end
MemoryMap.Instance.Dispose();
```
