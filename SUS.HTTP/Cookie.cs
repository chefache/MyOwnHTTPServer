﻿namespace SUS.HTTP
{
    public class Cookie
    {
        private string cookiesAsString;

        public Cookie(string cookiesAsString)
        {
            var cookieParts = cookiesAsString.Split(new char[] { '='}, 2);
            this.Name = cookieParts[0];
            this.Value = cookieParts[1];
        }

        public string Name { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return $"{this.Name}={this.Value}";
        }
    }
}