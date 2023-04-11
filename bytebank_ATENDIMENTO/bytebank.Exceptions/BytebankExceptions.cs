﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{

    [Serializable]
    public class ByteBankExceptions : Exception
    {
        public ByteBankExceptions() { }
        public ByteBankExceptions(string message) : base(" Aconteceu uma Exeção -> " + message) { }
        public ByteBankExceptions(string message, Exception inner) : base(message, inner) { }
        protected ByteBankExceptions(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
