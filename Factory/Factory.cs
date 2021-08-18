using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineIO;


namespace Factory
{
    public enum MemoryType
    {
        Memory = 0,
        Input = 1,
        Output = 2
    }

    public class MemoriesChangedEventArgs : EventArgs
    {
        public MemoriesChangedEventArgs()
        {
        }

        public MemoryBit[] MemoriesBit { get; set; }
        public MemoryByte[] MemoriesByte { get; set; }
        public MemoryShort[] MemoriesShort { get; set; }
        public MemoryInt[] MemoriesInt { get; set; }
        public MemoryLong[] MemoriesLong { get; set; }
        public MemoryFloat[] MemoriesFloat { get; set; }
        public MemoryDouble[] MemoriesDouble { get; set; }
        public MemoryString[] MemoriesString { get; set; }
        public MemoryDateTime[] MemoriesDateTime { get; set; }
        public MemoryTimeSpan[] MemoriesTimeSpan { get; set; }
    }
    public static class TestEvent
    {
        public static void RegisterEvent(Action<int, int> callback)
        {
            Console.WriteLine("Executing callback:");
            callback(10,10);
        }

    }

    public static class InputsNameChanged
    {
        private static Action<MemoriesChangedEventArgs> stored_callback;
        public static void LoadEvent(EngineIO.MemoryMap sender, EngineIO.MemoriesChangedEventArgs value)
        {
            MemoriesChangedEventArgs local = new MemoriesChangedEventArgs();
            local.MemoriesBit = value.MemoriesBit;
            local.MemoriesByte = value.MemoriesByte;
            local.MemoriesShort = value.MemoriesShort;
            local.MemoriesInt = value.MemoriesInt;
            local.MemoriesLong = value.MemoriesLong;
            local.MemoriesFloat = value.MemoriesFloat;
            local.MemoriesDouble = value.MemoriesDouble;
            local.MemoriesString = value.MemoriesString;
            local.MemoriesDateTime = value.MemoriesDateTime;
            local.MemoriesTimeSpan = value.MemoriesTimeSpan;

            stored_callback(local);
        }
        public static void RegisterEvent(Action<MemoriesChangedEventArgs> callback)
        {
            stored_callback = callback;
            EngineIO.MemoryMap.Instance.InputsNameChanged += new MemoriesChangedEventHandler(LoadEvent);
        }

    }
    public static class InputsValueChanged
    {
        private static Action<MemoriesChangedEventArgs> stored_callback;
        public static void LoadEvent(EngineIO.MemoryMap sender, EngineIO.MemoriesChangedEventArgs value)
        {
            MemoriesChangedEventArgs local = new MemoriesChangedEventArgs();
            local.MemoriesBit = value.MemoriesBit;
            local.MemoriesByte = value.MemoriesByte;
            local.MemoriesShort = value.MemoriesShort;
            local.MemoriesInt = value.MemoriesInt;
            local.MemoriesLong = value.MemoriesLong;
            local.MemoriesFloat = value.MemoriesFloat;
            local.MemoriesDouble = value.MemoriesDouble;
            local.MemoriesString = value.MemoriesString;
            local.MemoriesDateTime = value.MemoriesDateTime;
            local.MemoriesTimeSpan = value.MemoriesTimeSpan;
            Console.WriteLine("Firing InputsValueChanged event");
            stored_callback(local);
        }
        public static void RegisterEvent(Action<MemoriesChangedEventArgs> callback)
        {
            stored_callback = callback;
            EngineIO.MemoryMap.Instance.InputsValueChanged += new MemoriesChangedEventHandler(LoadEvent);
        }

    }

    public static class OutputsNameChanged
    {
        private static Action<MemoriesChangedEventArgs> stored_callback;
        public static void LoadEvent(EngineIO.MemoryMap sender, EngineIO.MemoriesChangedEventArgs value)
        {
            MemoriesChangedEventArgs local = new MemoriesChangedEventArgs();
            local.MemoriesBit = value.MemoriesBit;
            local.MemoriesByte = value.MemoriesByte;
            local.MemoriesShort = value.MemoriesShort;
            local.MemoriesInt = value.MemoriesInt;
            local.MemoriesLong = value.MemoriesLong;
            local.MemoriesFloat = value.MemoriesFloat;
            local.MemoriesDouble = value.MemoriesDouble;
            local.MemoriesString = value.MemoriesString;
            local.MemoriesDateTime = value.MemoriesDateTime;
            local.MemoriesTimeSpan = value.MemoriesTimeSpan;

            stored_callback(local);
        }
        public static void RegisterEvent(Action<MemoriesChangedEventArgs> callback)
        {
            stored_callback = callback;
            EngineIO.MemoryMap.Instance.OutputsNameChanged += new MemoriesChangedEventHandler(LoadEvent);
        }

    }
    public static class OutputsValueChanged
    {
        private static Action<MemoriesChangedEventArgs> stored_callback;
        public static void LoadEvent(EngineIO.MemoryMap sender, EngineIO.MemoriesChangedEventArgs value)
        {
            MemoriesChangedEventArgs local = new MemoriesChangedEventArgs();
            local.MemoriesBit = value.MemoriesBit;
            local.MemoriesByte = value.MemoriesByte;
            local.MemoriesShort = value.MemoriesShort;
            local.MemoriesInt = value.MemoriesInt;
            local.MemoriesLong = value.MemoriesLong;
            local.MemoriesFloat = value.MemoriesFloat;
            local.MemoriesDouble = value.MemoriesDouble;
            local.MemoriesString = value.MemoriesString;
            local.MemoriesDateTime = value.MemoriesDateTime;
            local.MemoriesTimeSpan = value.MemoriesTimeSpan;

            stored_callback(local);
        }
        public static void RegisterEvent(Action<MemoriesChangedEventArgs> callback)
        {
            stored_callback = callback;
            EngineIO.MemoryMap.Instance.OutputsValueChanged += new MemoriesChangedEventHandler(LoadEvent);
        }

    }
    public static class MemoriesNameChanged
    {
        private static Action<MemoriesChangedEventArgs> stored_callback;
        public static void LoadEvent(EngineIO.MemoryMap sender, EngineIO.MemoriesChangedEventArgs value)
        {
            MemoriesChangedEventArgs local = new MemoriesChangedEventArgs();
            local.MemoriesBit = value.MemoriesBit;
            local.MemoriesByte = value.MemoriesByte;
            local.MemoriesShort = value.MemoriesShort;
            local.MemoriesInt = value.MemoriesInt;
            local.MemoriesLong = value.MemoriesLong;
            local.MemoriesFloat = value.MemoriesFloat;
            local.MemoriesDouble = value.MemoriesDouble;
            local.MemoriesString = value.MemoriesString;
            local.MemoriesDateTime = value.MemoriesDateTime;
            local.MemoriesTimeSpan = value.MemoriesTimeSpan;

            stored_callback(local);
        }
        public static void RegisterEvent(Action<MemoriesChangedEventArgs> callback)
        {
            stored_callback = callback;
            EngineIO.MemoryMap.Instance.MemoriesNameChanged += new MemoriesChangedEventHandler(LoadEvent);
        }

    }
    public static class MemoriesValueChanged
    {
        private static Action<MemoriesChangedEventArgs> stored_callback;
        public static void LoadEvent(EngineIO.MemoryMap sender, EngineIO.MemoriesChangedEventArgs value)
        {
            MemoriesChangedEventArgs local = new MemoriesChangedEventArgs();
            local.MemoriesBit = value.MemoriesBit;
            local.MemoriesByte = value.MemoriesByte;
            local.MemoriesShort = value.MemoriesShort;
            local.MemoriesInt = value.MemoriesInt;
            local.MemoriesLong = value.MemoriesLong;
            local.MemoriesFloat = value.MemoriesFloat;
            local.MemoriesDouble = value.MemoriesDouble;
            local.MemoriesString = value.MemoriesString;
            local.MemoriesDateTime = value.MemoriesDateTime;
            local.MemoriesTimeSpan = value.MemoriesTimeSpan;

            stored_callback(local);
        }
        public static void RegisterEvent(Action<MemoriesChangedEventArgs> callback)
        {
            stored_callback = callback;
            EngineIO.MemoryMap.Instance.MemoriesValueChanged += new MemoriesChangedEventHandler(LoadEvent);
        }

    }
    public static class MemoryMap 
    {

        public static class Instance
        {
            
            public static MemoryBit GetBit(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetBit(name, (EngineIO.MemoryType)type);
            }
            public static MemoryBit GetBit(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetBit((EngineIO.MemoryType)type);
            }
            public static MemoryBit GetBit(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetBit(address, (EngineIO.MemoryType)type);
            }
            public static MemoryBit[] GetBitMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetBitMemories((EngineIO.MemoryType)type);
            }
            public static MemoryByte GetByte(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetByte((EngineIO.MemoryType)type);
            }
            public static MemoryByte GetByte(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetByte(address, (EngineIO.MemoryType)type);
            }
            public static MemoryByte GetByte(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetByte(name, (EngineIO.MemoryType)type);
            }
            public static Memory<DateTime> GetDateTime(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDateTime(name, (EngineIO.MemoryType)type);
            }
            public static MemoryDateTime GetDateTime(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDateTime(address, (EngineIO.MemoryType)type);
            }
            public static MemoryDateTime GetDateTime(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDateTime((EngineIO.MemoryType)type);
            }
            public static MemoryDateTime[] GetDateTimeMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDateTimeMemories((EngineIO.MemoryType)type);
            }
            public static MemoryDouble GetDouble(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDouble(address, (EngineIO.MemoryType)type);
            }
            public static MemoryDouble GetDouble(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDouble((EngineIO.MemoryType)type);
            }
            public static MemoryDouble GetDouble(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDouble(name, (EngineIO.MemoryType)type);
            }
            public static MemoryDouble[] GetDoubleMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetDoubleMemories((EngineIO.MemoryType)type);
            }
            public static MemoryFloat GetFloat(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetFloat(address, (EngineIO.MemoryType)type);
            }
            public static MemoryFloat GetFloat(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetFloat((EngineIO.MemoryType)type);
            }
            public static MemoryFloat GetFloat(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetFloat(name, (EngineIO.MemoryType)type);
            }
            public static MemoryFloat[] GetFloatMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetFloatMemories((EngineIO.MemoryType)type);
            }
            public static MemoryInt GetInt(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetInt(name, (EngineIO.MemoryType)type);
            }
            public static MemoryInt GetInt(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetInt((EngineIO.MemoryType)type);
            }
            public static MemoryInt GetInt(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetInt(address, (EngineIO.MemoryType)type);
            }
            public static MemoryInt[] GetIntMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetIntMemories((EngineIO.MemoryType)type);
            }
            public static MemoryLong GetLong(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetLong(name, (EngineIO.MemoryType)type);
            }
            public static MemoryLong GetLong(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetLong((EngineIO.MemoryType)type);
            }
            public static MemoryLong GetLong(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetLong(address, (EngineIO.MemoryType)type);
            }
            public static MemoryLong[] GetLongMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetLongMemories((EngineIO.MemoryType)type);
            }
            public static MemoryShort GetShort(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetShort(address, (EngineIO.MemoryType)type);
            }
            public static MemoryShort GetShort(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetShort(name, (EngineIO.MemoryType)type);
            }
            public static MemoryShort GetShort(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetShort((EngineIO.MemoryType)type);
            }
            public static MemoryShort[] GetShortMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetShortMemories((EngineIO.MemoryType)type);
            }
            public static MemoryString GetString(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetString(name, (EngineIO.MemoryType)type);
            }
            public static MemoryString GetString(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetString((EngineIO.MemoryType)type);
            }
            public static MemoryString GetString(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetString(address, (EngineIO.MemoryType)type);
            }
            public static MemoryString[] GetStringMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetStringMemories((EngineIO.MemoryType)type);
            }
            public static MemoryTimeSpan GetTimeSpan(int address, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetTimeSpan(address, (EngineIO.MemoryType)type);
            }
            public static Memory<TimeSpan> GetTimeSpan(string name, MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetTimeSpan(name, (EngineIO.MemoryType)type);
            }
            public static MemoryTimeSpan GetTimeSpan(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetTimeSpan((EngineIO.MemoryType)type);
            }
            public static MemoryTimeSpan[] GetTimeSpanMemories(MemoryType type)
            {
                return EngineIO.MemoryMap.Instance.GetTimeSpanMemories((EngineIO.MemoryType)type);
            }
            public static void Update()
            {
                EngineIO.MemoryMap.Instance.Update();
            }

            public static void Dispose()
            {
                EngineIO.MemoryMap.Instance.Dispose();
            }

            public static void Clear()
            {
                EngineIO.MemoryMap.Instance.Clear();
            }
            
        }

        public static int BitCount
        {
            get
            {
                return EngineIO.MemoryMap.BitCount;
            }
            
        }

        public static int ByteCount
        {
            get
            {
                return EngineIO.MemoryMap.ByteCount;
            }

        }

        public static int StringCount
        {
            get
            {
                return EngineIO.MemoryMap.StringCount;
            }

        }

        public static int IntCount
        {
            get
            {
                return EngineIO.MemoryMap.IntCount;
            }

        }

        public static int FloatCount
        {
            get
            {
                return EngineIO.MemoryMap.FloatCount;
            }

        }

        public static int TimeSpanCount
        {
            get
            {
                return EngineIO.MemoryMap.TimeSpanCount;
            }

        }

        public static int DoubleCount
        {
            get
            {
                return EngineIO.MemoryMap.DoubleCount;
            }

        }

        public static int DateTimeCount
        {
            get
            {
                return EngineIO.MemoryMap.DateTimeCount;
            }

        }

        public static int ShortCount
        {
            get
            {
                return EngineIO.MemoryMap.ShortCount;
            }

        }

        public static int LongCount
        {
            get
            {
                return EngineIO.MemoryMap.LongCount;
            }

        }

    }

    
}
