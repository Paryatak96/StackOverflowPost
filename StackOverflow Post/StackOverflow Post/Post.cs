using System;

namespace StackOverflow_Post
{
    class Post
    {
        public string TytułPostu { get; private set; }
        public string Opis { get; private set; }
        public uint Like { get; private set; }
        public uint Unlike { get; private set; }
        public DateTime DataDodania{ get; private set; }
        public Post(string tytułpostu, string opis, DateTime datadodania)
        {
            TytułPostu = tytułpostu;
            Opis = opis;
            DataDodania = datadodania;
        }
        public void DajLike(uint like)
        {
            Like += like;
        }
        public void DajUnlike(uint unlike)
        {
            Unlike += unlike;
        }
    }
}
