﻿namespace Frotz.Other
{
    public static class GraphicsFont
    {
        public static string GetLines(int id) => id switch
        {
            32 => "0000000000000000",
            33 => "000004067F060400",
            34 => "000010307F301000",
            35 => "8040201008040201",
            36 => "0102040810204080",
            37 => "0000000000000000",
            38 => "00000000FF000000",
            39 => "000000FF00000000",
            40 => "1010101010101010",
            41 => "0808080808080808",
            42 => "101010FF00000000",
            43 => "00000000FF101010",
            44 => "10101010F0101010",
            45 => "080808080F080808",
            46 => "08080808F8000000",
            47 => "000000F808080808",
            48 => "0000001F10101010",
            49 => "101010101F000000",
            50 => "08080808F8040201",
            51 => "010204F808080808",
            52 => "8040201F10101010",
            53 => "101010101F204080",
            54 => "FFFFFFFFFFFFFFFF",
            55 => "FFFFFFFFFF000000",
            56 => "000000FFFFFFFFFF",
            57 => "1F1F1F1F1F1F1F1F",
            58 => "F8F8F8F8F8F8F8F8",
            _  => "FF818181818181FF"
        };
    }
}