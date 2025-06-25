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

        // Sounds
        public const string INTRO_BGM_PATH = "Sounds/IntroBGM";
        public const string PLAY_BGM_PATH = "Sounds/PlayBGM";
        public const string OUTRO_BGM_PATH = "Sounds/OutroBGM";
        public const string JUMP_PATH = "Sounds/Jump";
        public const string GAIN_ITEM_PATH = "Sounds/GainItem";
        public const string COLLISION_PATH = "Sounds/Collision";
        
        // Player
        public const float LINEAR_VELOCITY_Y_LIMIT = 10.5f;
        public const float JUMP_POWER = 7f;
        
        // Item
        public const float MOVE_SPEED_MIN = 3f;
        public const float RETURN_Y_MIN = -3f;
        public const float RETURN_Y_MAX = -8f;
        public const float START_POSITION_X = 45f;
        public const float BACKGROUND_END_X = -10f;
        public const float SPEED_UP_INTERVAL = 5f;
        
        // Map
        public const float OFFSET_SPEED = 0.1f;
    }
}