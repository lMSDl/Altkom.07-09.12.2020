using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Facade.III
{
    class ConverterFacade : IJsonCoverter, IXmlConverter, IByteArrayConveter
    {
        private IJsonCoverter _jsonCoverter;
        private IXmlConverter _xmlConverter;
        private IByteArrayConveter _byteArrayConveter;

        public ConverterFacade(IJsonCoverter jsonCoverter, IXmlConverter xmlConverter, IByteArrayConveter byteArrayConveter)
        {
            _jsonCoverter = jsonCoverter;
            _xmlConverter = xmlConverter;
            _byteArrayConveter = byteArrayConveter;
        }

        public byte[] ToByteArray()
        {
            return _byteArrayConveter.ToByteArray();
        }

        public string ToJson()
        {
            return _jsonCoverter.ToJson();
        }

        public string ToXml()
        {
            return _xmlConverter.ToXml();
        }
    }
}
