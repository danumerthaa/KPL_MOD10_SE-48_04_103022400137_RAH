namespace KPL_MOD10_SE_48_04_103022400137_RAH
{
    public class Games
    {
        public int id {  get; set; }
        public string Nama { get; set; }
        public string Developer { get; set; }
        public int TahunRilis { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public List<string> Platform { get; set; }
        public List<string> Mode { get; set; }
        public Boolean isOnline { get; set; }
        public int Harga { get; set; }
     }
}
