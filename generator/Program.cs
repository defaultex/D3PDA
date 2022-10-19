using System.Text.RegularExpressions;

partial class Program {
    static readonly string[,] StatListL = new string[,] { 
        // Name, EQType
        { "MIT", "22" },
        { "EVA", "403" },
        { "STR", "5" },
        { "STA", "6" },
        { "AGI", "8"},
        { "DEX", "7" },
        { "WIS", "9" },
        { "INT", "10" },
        { "CHA", "11" }
    };

    static readonly string[,] StatListR = new string[,] {
        // Name, EQType
        { "OFF", "23" },
        { "ACC", "402" },
        { "MR", "16"},
        { "CR", "15" },
        { "FR", "14"},
        { "DR", "13" },
        { "PR", "12" },
        { "CO", "136" },
        { "HST", "211" }
    };

    // ----------------------------------------------------------
    //  new generators    
    // ----------------------------------------------------------

    static string ReplaceLabelTypes(string source) {
        const string EQLabelPattern = @"\[EQLabelType.(?<name>[a-zA-Z0-9]+)\]";
        Match m;
        while ((m = Regex.Match(source, EQLabelPattern)).Success) {
            string name = m.Groups.GetValueOrDefault("name").Value;
            int value = (int)Enum.Parse(typeof(EQLabelType), name);
            source = source.Replace(m.Value, value.ToString());
            Console.WriteLine($"   {m.Value} => {value}");
        }
        return source;
    }

    static string ReplaceGaugeTypes(string source) {
        const string EQGaugePattern = @"\[EQGaugeType.(?<name>[a-zA-Z0-9]+)\]";
        Match m;
        while ((m = Regex.Match(source, EQGaugePattern)).Success) {
            string name = m.Groups.GetValueOrDefault("name").Value;
            int value = (int)Enum.Parse(typeof(EQGaugeType), name);
            source = source.Replace(m.Value, value.ToString());
            Console.WriteLine($"   {m.Value} => {value}");
        }
        return source;
    }

    static string ProcessEQTypes(string source) {
        source = ReplaceLabelTypes(source);
        source = ReplaceGaugeTypes(source);
        return source;
    }

    static string ProcessIndices(string source, int i) {
        const string IndexPattern = @"\[i(\+(?<value>[0-9]+))*\]";
        Match m;
        while ((m = Regex.Match(source, IndexPattern)).Success) {
            string strValue;
            if (m.Groups.TryGetValue("value", out Group g)) {
                strValue = g.Value;
            } else {
                strValue = "0";
            }
            int value = string.IsNullOrEmpty(strValue) ? 0 : int.Parse(strValue);
            string newValue = $"{i + value}";
            source = source.Replace(m.Value, newValue);
            Console.WriteLine($"   {m.Value} => {newValue}");
        }
        return source;
    }

    static void GenerateSpellGems() {
        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/Spell.xmltemplate", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 0; i < 14; i++) {
            string outFilename = $"../spell_window/Spell{i}.xml";
            Console.WriteLine($"Generating {outFilename}");
            string output = ProcessIndices(original, i);
            output = ProcessEQTypes(output);
            File.WriteAllText(outFilename, output);
        }
    }

    static void GenerateExtTarget() {
        const int ExtTargetCount = 20;

        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/ExtTarget.xmltemplate", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 0; i < ExtTargetCount; i++) {
            string outFilename = $"../ext_target_window/ExtTarget{i}.xml";
            Console.WriteLine($"Generating {outFilename}");
            string output = ProcessIndices(original, i);
            output = ProcessEQTypes(output);
            File.WriteAllText(outFilename, output);
        }
    }

    static void GenerateGroup() {
        const int GroupMemberCount = 6;

        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/Group.xmltemplate", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 1; i < GroupMemberCount; i++) {
            string outFilename = $"../group_window/Group{i}.xml";
            Console.WriteLine($"Generating {outFilename}");
            string output = ProcessIndices(original, i);
            output = ProcessEQTypes(output);
            File.WriteAllText(outFilename, output);
        }
    }

    static void GenerateBuffs() {
        const int BuffCount = 42;

        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/Buff.xmltemplate", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 0; i < BuffCount; i++) {
            string outFilename = $"../buff_window/Buff{i}.xml";
            Console.WriteLine($"Generating {outFilename}");
            string output = ProcessIndices(original, i);
            output = ProcessEQTypes(output);
            File.WriteAllText(outFilename, output);
        }
    }

    static void GenerateSongs() {
        const int SongCount = 30;

        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/Song.xmltemplate", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 0; i < SongCount; i++) {
            string outFilename = $"../song_window/Song{i}.xml";
            Console.WriteLine($"Generating {outFilename}");
            string output = ProcessIndices(original, i);
            output = ProcessEQTypes(output);
            File.WriteAllText(outFilename, output);
        }
    }

    // ----------------------------------------------------------
    //  old generators
    // ----------------------------------------------------------


    static void GeneratePlayerItems() {
        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/PlayerHP.xml", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        File.WriteAllText("../player_window/PlayerHP.xml", original);

        string mana =
            System.Text.RegularExpressions.Regex.Replace(
                System.Text.RegularExpressions.Regex.Replace(original,
                    @"<FillTint>\n\s*<R>240</R>\s*<G>0</G>\s*<B>0</B>\s*</FillTint>",
                    "<FillTint><R>0</R><G>0</G><B>240</B></FillTint>"),
                    "\\s*<Gauge\\sitem=\"Pet_HP\">(\\n.+)+?(</Gauge>)", ""
                )
            .Replace("<Pieces>Pet_HP</Pieces>", "")
            .Replace("Text>HP", "Text>MP")

            .Replace("HPPerLabel", "ManPercLabel") // special case
            .Replace("HPNumber", "MpNumber") // special case
            .Replace("HP", "Mana")

            .Replace("EQType>212<", "EQType>213<") // regen number
            .Replace("EQType>70<", "EQType>128<") // value number
            .Replace("EQType>19<", "EQType>20<") // percent number
            .Replace("EQType>1<", "EQType>2<"); // gauge
        File.WriteAllText("../player_window/PlayerMP.xml", mana);

        string end =
            System.Text.RegularExpressions.Regex.Replace(
                System.Text.RegularExpressions.Regex.Replace(original,
                    @"<FillTint>\n\s*<R>240</R>\s*<G>0</G>\s*<B>0</B>\s*</FillTint>",
                    "<FillTint><R>255</R><G>180</G><B>0</B></FillTint>"),
                    "\\s*<Gauge\\sitem=\"Pet_HP\">(\\n.+)+?(</Gauge>)", ""
                )
            .Replace("<Pieces>Pet_HP</Pieces>", "")
            .Replace("Text>HP", "Text>EP")

            .Replace("HPLabel", "FatigueLabel") // special case
            .Replace("HPPerLabel", "FatiguePercLabel") // special case
            .Replace("HPNumber", "EnNumber") // special case
            .Replace("PlayerHP", "PlayerFatigue")
            .Replace("HP", "EN")

            .Replace("EQType>212<", "EQType>214<") // regen number
            .Replace("EQType>70<", "EQType>129<") // value number
            .Replace("EQType>19<", "EQType>21<") // percent number
            .Replace("EQType>1<", "EQType>3<"); // gauge
        File.WriteAllText("../player_window/PlayerEN.xml", end);
    }
    
    static string GenerateStatItem(string source, int i, string[,] lut) => source
            .Replace("MIT", lut[i, 0])
            .Replace("EQType>22", $"EQType>{lut[i, 1]}");

    static void GenerateStatusItemsL() {
        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/StatTemplateL.xml", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 0; i < StatListL.GetLength(0); i++) {
            File.WriteAllText(
                $"../status_window/Status_{StatListL[i, 0]}Display.xml", 
                GenerateStatItem(original, i, StatListL)
            );
        }
    }

    static void GenerateStatusItemsR() {
        string original = string.Empty;
        using (FileStream stream = File.Open("./templates/StatTemplateR.xml", FileMode.Open)) {
            using (StreamReader reader = new StreamReader(stream)) {
                original = reader.ReadToEnd();
            }
        }

        for (int i = 0; i < StatListR.GetLength(0); i++) {
            File.WriteAllText(
                $"../status_window/Status_{StatListR[i, 0]}Display.xml", 
                GenerateStatItem(original, i, StatListR)
            );
        }
    }

    // ----------------------------------------------------------
    //  main
    // ----------------------------------------------------------

    static void Main(string[] args) {
        GenerateSpellGems();
        GenerateExtTarget();
        GenerateGroup();
        GenerateBuffs();
        GenerateSongs();

        GeneratePlayerItems();
        GenerateStatusItemsL();
        GenerateStatusItemsR();

        //ImGuiTest();
    }

    static void ImGuiTest() {
        Vector4 m_color = Vector4.One;
        bool m_toolActive = false;

        ImGui.Begin("ImGui Test", ref m_toolActive, ImGuiWindowFlags.MenuBar);
        if (ImGui.BeginMenuBar()) {
            if (ImGui.BeginMenu("File")) {
                if (ImGui.MenuItem("Open..", "Ctrl+O")) {

                }
                if (ImGui.MenuItem("Save", "Ctrl+S")) {

                }
                if (ImGui.MenuItem("Close", "Ctrl+W")) {
                    m_toolActive = false;
                }
                ImGui.EndMenu();
            }
            ImGui.EndMenuBar();
        }

        ImGui.ColorEdit4("Color", ref m_color);

        float[] values = new[] { 0.2f, 0.1f, 1.0f, 0.5f, 0.9f, 2.2f };
        ImGui.PlotLines("Frame Times", ref values[0], values.Length);

        ImGui.TextColored(new(1, 1, 0, 1), "Important Stuff");
        ImGui.BeginChild("Scrolling");
        for (int i = 0; i < 50; i++) {
            ImGui.Text($"{i:D4}: Some Text");
        }
        ImGui.EndChild();
        ImGui.End();
    }
}