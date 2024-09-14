# HotKeyManager

## 關於
在這之前，用下班時間寫了一個小型的Windows Form 程式來自用。<br>
用if-else寫了一大大堆的快速鍵。所有快捷鍵都計載在ReadMe.md裡面，<br>
初期用的很爽，不愧是自己寫的，完全符合自己需求。<br>
也寫了一些很暴力的快速鍵，像甚麼直接關閉不要問我要不要存檔。<br>
開新檔案不詢問現在編輯中檔案需不需要存檔。<br>
都是大部分程式不會給的暴力快速鍵(不過理由也很明顯，後面就知道)。<br>
然後每次更新都會把快速鍵寫到文字檔裡記錄起來。<br>

Happy~~~<br>

功能大致穩定之後就把很多不常用的快速鍵給忘了。<br>
後來有一次不小心按到一個自己寫來偷懶的快速鍵，就是那個強制開新檔案不詢問當下編輯中檔案是否要存檔。<br>
於是好幾個小時的成果沒了。<br>
回去查才發現Readme自己根本懶得看，然後翻程式碼
> 這鬼東西是要怎麼查起，猴子寫的嗎！？<br>

但是要調整也不知道從哪邊調整起。<br>
尤其是快速鍵的部分。<br>
想說快速鍵或按建設定器很常見，應該不會多難寫，順便當個Side-Project練習。<br>
所以就來寫了。<br>

## 功能展示
![展示動畫](https://github.com/LowDensity/HotKeyManager/HotkeyManagerDemo.gif)


## 範例
- 以下內容可在 ManagerDemo.cs 中找到。
- HotkeyManager 指的是設定器視窗。

1. 建立快速鍵資料
    ```csharp
                //建立快速鍵設定物件
                hotkeyConfig = new HotkeyConfiguration(this.GetType());
                hotkeyConfig.Initialize();
                //建立快速鍵設定資料。
                hotkeyConfig.SetHotkey(
                    new HotkeyData { 
                        Name = "快速鍵一",
                        Description = "隨機變更下方方塊的顏色。",
                        Combination = Keys.Q });
                hotkeyConfig.SetHotkey(
                    new HotkeyData {
                        Name = "快速鍵二",
                        Description = "減少區塊中方塊數量。",
                        Combination = Keys.W });
                hotkeyConfig.SetHotkey(
                    new HotkeyData {
                        Name = "快速鍵三",
                        Description = "增加區塊中方塊數量(最多五個)。",
                        Combination = Keys.E });
                hotkeyConfig.SetHotkey(
                    new HotkeyData {
                        Name = "快速鍵四",
                        Description = "在下方區塊中顯示一個隨機數字。",
                        Combination = Keys.R } );
                hotkeyConfig.Save();
    ```

1. 將快速鍵與Handler接起來。
    ```csharp
                //這邊是為了可讀性跟維護姓所以將前面的快速件轉成Dictionary處理，犧牲效能。
                var hokeyDic = hotkeyConfig.GetDitcionary();
                //如果沒有關閉nullable reference type的話這部分可能會有綠毛蟲，
                //可以視需求加或不佳驚嘆號。
                hokeyDic["快速鍵一"].Handler = Hhotkey1_Handler!;
                hokeyDic["快速鍵二"].Handler = Hhotkey2_Handler!;
                hokeyDic["快速鍵三"].Handler = Hhotkey3_Handler!;
                hokeyDic["快速鍵四"].Handler = Hhotkey4_Handler!;
                allHotkeys = hokeyDic.Values.ToArray();
    ```

1. 撰寫一個通用的 KeyEventHandler並接上剛才設定的 allHotkeys
    ```csharp
            private void ManagerDemoKeyDown(object sender, KeyEventArgs e)
            {
                Hotkey? hotkey = allHotkeys.FirstOrDefault(
                    hotkey => hotkey.Data.Combination == e.KeyData
                    );
                //如果沒有找到快速鍵，就甚麼都不做。
                if(hotkey is null) return;
                hotkey.Handler(sender, e);
        }
    ```
- 按下play。

