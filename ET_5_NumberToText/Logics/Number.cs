using ET_5_NumberToText.Logics.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_5_NumberToText.Logics
{
    class Number
    {
        public NumberToTextConverter Converter { private get; set; }

        public long Value { get; set; }

        public Number(long value, NumberToTextConverter converter)
        {
            Value = value;
            Converter = converter;
        }

        public bool CanConvertToText()
        {
            return Converter.CanConvertNumber(Value);
        }
        public string ConvertToText()
        {
            return Converter.ConvertNumber(Value);
        }
    }
}
