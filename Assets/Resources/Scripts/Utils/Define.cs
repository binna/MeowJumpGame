namespace Cat
{
    public static class Define
    {
        public enum ColliderType
        {
            Pipe,
            Apple,
            Both
        }

        public static class TagType
        {
            public const string CHURU = "Churu";
            public const string PIPE = "Pipe";
            public const string PLAYER = "Player";
            public const string GROUND = "Ground";
        }

        public static class AnimationParameter
        {
            public const string JUMP = "Jump";
            public const string GROUND = "Ground";
        }
    }
}