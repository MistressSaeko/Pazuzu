using System;
using System.IO;

namespace Pazuzu
{
    class ROMHandler
    {
        FileStream   ROM;
        MemoryStream Mem;
        BinaryReader InputBinary;
        BinaryWriter OutputBinary;
        bool ROMChanged { get; set; }

        public ROMHandler()
        {
            ROMChanged = false;
        }

        public void OpenROM(string FileName)
        {
            ROM = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            Mem = new MemoryStream();
            ROM.CopyTo(Mem);
            ROM.Close();

            InputBinary  = new BinaryReader(Mem);
            OutputBinary = new BinaryWriter(Mem);

            ROMChanged = false; 
        }

        public void SaveROM(string FileName)
        {
            ROM.Close();
            ROM = new FileStream(FileName, FileMode.Open, FileAccess.Write);
            Mem.WriteTo(ROM);
        }

        public void CloseROM()
        {
            if (ROM != null)
                ROM.Close();
            if (Mem != null)
                Mem.Close();
        }

        public void SeekROM(int FileOffset)
        {
            if (Mem != null)
                Mem.Seek(FileOffset, SeekOrigin.Begin);
        }

        public bool IsOpen()
        {
            return Mem != null;
        }

        public byte Read8()
        {
            if (ROM != null)
                return InputBinary.ReadByte();
            else
                throw new NullReferenceException();
        }

        public ushort Read16()
        {
            if (ROM != null)
                return InputBinary.ReadUInt16();
            else
                throw new NullReferenceException();
        }

        public uint Read24()
        {
            if (ROM != null)
            {
                uint i = InputBinary.ReadByte();
                i |= Convert.ToUInt32(InputBinary.ReadByte() << 8);
                i |= Convert.ToUInt32(InputBinary.ReadByte() << 16);
                return i;
            }
            else
                throw new NullReferenceException();
        }

        public uint Read32()
        {
            if (ROM != null)
                return InputBinary.ReadUInt32();
            else
                throw new NullReferenceException();
        }

        public byte Read8(int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                return InputBinary.ReadByte();
            }
            else
                throw new NullReferenceException();
        }

        public ushort Read16(int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                return InputBinary.ReadUInt16();
            }
            else
                throw new NullReferenceException();
        }

        public uint Read24(int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                uint i = InputBinary.ReadByte();
                i |= Convert.ToUInt16(InputBinary.ReadByte() << 8);
                i |= Convert.ToUInt32(InputBinary.ReadByte() << 16);
                return i;
            }
            else
                throw new NullReferenceException();
        }

        public uint Read32(int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                return InputBinary.ReadUInt32();
            }
            else
                throw new NullReferenceException();
        }

        public void Write8(byte val)
        {
            if (ROM != null)
                OutputBinary.Write(val);
            else
                throw new NullReferenceException();
        }

        public void Write16(ushort val)
        {
            if (ROM != null)
                OutputBinary.Write(val);
            else
                throw new NullReferenceException();
        }

        public void Write24(uint val)
        {
            if (ROM != null)
            {
                byte[] i = new byte[3];

                i[0] = Convert.ToByte(val & 0xFF);
                i[1] = Convert.ToByte((val & 0xFF00) >> 8);
                i[2] = Convert.ToByte((val & 0xFF0000) >> 16);
                Write8(i[0]);
                Write8(i[1]);
                Write8(i[2]);
            }
            else
                throw new NullReferenceException();
        }

        public void Write32(uint val)
        {
            if (ROM != null)
                OutputBinary.Write(val);
            else
                throw new NullReferenceException();
        }

        public void Write8(byte val, int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                Write8(val);
            }
            else
                throw new NullReferenceException();
        }

        public void Write16(ushort val, int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                Write16(val);
            }
            else
                throw new NullReferenceException();
        }

        public void Write24(uint val, int FileOffset)
        {
            if (ROM != null)
            {
                byte[] i = new byte[3];

                i[0] = Convert.ToByte(val & 0xFF);
                i[1] = Convert.ToByte((val & 0xFF00) >> 8);
                i[2] = Convert.ToByte((val & 0xFF0000) >> 16);
                SeekROM(FileOffset);
                Write8(i[0]);
                Write8(i[1]);
                Write8(i[2]);

            }
            else
                throw new NullReferenceException();
        }


        public void Write32(uint val, int FileOffset)
        {
            if (ROM != null)
            {
                SeekROM(FileOffset);
                Write32(val);
            }
            else
                throw new NullReferenceException();
        }
    }
}
