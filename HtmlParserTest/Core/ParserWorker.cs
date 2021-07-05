using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParserTest.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HTMLLoader loader;
        bool isActive;
        #region Properties
        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }
        public IParserSettings ParserSettings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HTMLLoader(value);
            }
        }
        public bool IsActive
        {
            get 
            {
                return isActive;
            }
        }
        #endregion
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }
        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }
        public void Start()
        {

        }
        public void Abort()
        {

        }
        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i < parserSettings.EndPoint; i++)
            {

            }
        }
    }
}
