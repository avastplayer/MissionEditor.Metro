using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MissionEditor.Metro
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public HashSet<int> WriteRows { get; set; } = new HashSet<int>();
        public int SelectDataRow { get; set; }
        public AssetManager AssetManager = new AssetManager();

        public MainWindow()
        {
            InitializeComponent();

            MissionDataGrid.ItemsSource = AssetManager.MissionDatatable.DefaultView;

            //assetManager.GetNpcInfo(14039, out string npcName, out int headId, out string mapName);
            //Console.WriteLine(npcName);
            //Console.WriteLine(mapName);

            //int imagesetName = (headId - 9000) / 4;
            //Head.Source = assetManager.GetImage(assetManager.HeadImageset + imagesetName, headId.ToString());
        }

        private void MissionDataGrid_click(object sender, MouseButtonEventArgs e)
        {
            SelectDataRow = GetSelectedRow();

            BindingTextBoxValue(MinLevelTextBox, "[MinLevel]");
            BindingTextBoxValue(MaxLevelTextBox, "[MaxLevel]");
            BindingTextBoxValue(TransMinLevelTextBox, "[TransMinLevel]");
            BindingTextBoxValue(TransMaxLevelTextBox, "[TransMaxLevel]");
            //TODO: RequestMissionList
            //TODO: RequestRoleIDList
            //TODO: PostMissionList
            BindingTextBoxValue(TransformIDTextBox, "[TransformID]");
            BindingTextBoxValue(NoteInfoTextBox, "[NoteInfo]");
            BindingTextBoxValue(ExpRewardTextBox, "[ExpReward]");
            BindingTextBoxValue(MoneyRewardTextBox, "[MoneyReward]");
            BindingTextBoxValue(PetExpRewardTextBox, "[PetExpReward]");
            BindingTextBoxValue(ShengWangTextBox, "[ShengWang]");
            BindingTextBoxValue(SMoneyTextBox, "[SMoney]");
            RewardMapJumpTypeComboBox.SelectedIndex = DataProcess.GetRewardMapJumpTypeSelectIndex(
                Convert.ToInt32(AssetManager.MissionDatatable.Rows[SelectDataRow]["RewardMapJumpType"]));
            BindingTextBoxValue(RewardMapIDTextBox, "[RewardMapID]");
            BindingTextBoxValue(RewardMapXPosTextBox, "[RewardMapXPos]");
            BindingTextBoxValue(RewardMapYPosTextBox, "[RewardMapYPos]");
            BindingTextBoxValue(ProcessBarTimeTextBox, "[ProcessBarTime]");
            BindingTextBoxValue(ProcessBarTextTextBox, "[ProcessBarText]");
            BindingTextBoxValue(ProcessBarColorTextBox, "[ProcessBarColor]");
            //TODO：DisPlayNPCID
            //TODO：RewardItemIDList
            //TODO：RewardItemNumList
            //TODO：RewardItemShapeIDList
            //TODO：RewardItemIsBindList
            MissionTypeComboBox.SelectedIndex = DataProcess.GetMissionTypeSelectIndex(
                Convert.ToInt32(AssetManager.MissionDatatable.Rows[SelectDataRow]["MissionType"]));
            BindingTextBoxValue(ActiveInfoNpcIDTextBox, "[ActiveInfoNpcID]");
            BindingTextBoxValue(ActiveInfoMapIDTextBox, "[ActiveInfoMapID]");
            BindingTextBoxValue(ActiveInfoLeftPosTextBox, "[ActiveInfoLeftPos]");
            BindingTextBoxValue(ActiveInfoTopPosTextBox, "[ActiveInfoTopPos]");
            BindingTextBoxValue(ActiveInfoRightPosTextBox, "[ActiveInfoRightPos]");
            BindingTextBoxValue(ActiveInfoBottomPosTextBox, "[ActiveInfoBottomPos]");
            BindingTextBoxValue(ActiveInfoTargetIDTextBox, "[ActiveInfoTargetID]");
            BindingTextBoxValue(ActiveInfoTargetNumTextBox, "[ActiveInfoTargetNum]");
            BindingTextBoxValue(ActiveInfoMiniStepTextBox, "[ActiveInfoMiniStep]");
            BindingTextBoxValue(ActiveInfoStepProbabilityTextBox, "[ActiveInfoStepProbability]");
            BindingTextBoxValue(ActiveInfoMaxStepTextBox, "[ActiveInfoMaxStep]");
            ActiveInfoTeamStateComboBox.SelectedIndex = DataProcess.GetActiveInfoTeamStateSelectIndex(
                Convert.ToInt32(AssetManager.MissionDatatable.Rows[SelectDataRow]["ActiveInfoTeamState"]));
            BindingTextBoxValue(ActiveInfoTimeLimitTextBox, "[ActiveInfoTimeLimit]");
            BindingTextBoxValue(ActiveInfoIsRestartTimerTextBox, "[ActiveInfoIsRestartTimer]");
            BindingTextBoxValue(ActiveInfoGiveBackMoneyTextBox, "[ActiveInfoGiveBackMoney]");
            BindingTextBoxValue(ActiveInfoGiveBackPetIDTextBox, "[ActiveInfoGiveBackPetID]");
            BindingTextBoxValue(ActiveInfoUseItemIDTextBox, "[ActiveInfoUseItemID]");
            BindingTextBoxValue(ActiveInfoOtherTypeTextBox, "[ActiveInfoOtherType]");
            BindingTextBoxValue(QuestionInfoCorrectAnswerTextBox, "[QuestionInfoCorrectAnswer]");
            //TODO：QuestionInfoWrongAnswerList
            BindingTextBoxValue(QuestionInfoNpcIDTextBox, "[QuestionInfoNpcID]");
            BindingTextBoxValue(QuestionInfoConversionTextBox, "[QuestionInfoConversion]");
            BindingTextBoxValue(TaskInfoDescriptionListATextBox, "[TaskInfoDescriptionListA]");
            BindingTextBoxValue(TaskInfoPurposeListATextBox, "[TaskInfoPurposeListA]");
            BindingTextBoxValue(TaskInfoTraceListATextBox, "[TaskInfoTraceListA]");
            BindingTextBoxValue(AIInfoAIIDTextBox, "[AIInfoAIID]");
            //AIInfoBattleResult
            AIInfoDeathPunishComboBox.SelectedIndex = DataProcess.GetAIInfoDeathPunishSelectIndex(
                Convert.ToInt32(AssetManager.MissionDatatable.Rows[SelectDataRow]["AIInfoDeathPunish"]));
            AIInfoTeamSteateComboBox.SelectedIndex = DataProcess.GetAIInfoTeamSteateSelectIndex(
                Convert.ToInt32(AssetManager.MissionDatatable.Rows[SelectDataRow]["AIInfoTeamSteate"]));
            BindingTextBoxValue(AIInfoBattleLevelTextBox, "[AIInfoBattleLevel]");
            BattleInfoBattleMapTypeComboBox.SelectedIndex = DataProcess.GetBattleInfoBattleMapTypeSelectIndex(
                Convert.ToInt32(AssetManager.MissionDatatable.Rows[SelectDataRow]["BattleInfoBattleMapType"]));
            BindingTextBoxValue(BattleInfoBattleZoneIDTextBox, "[BattleInfoBattleZoneID]");
            BindingTextBoxValue(BattleInfoDropTextBox, "[BattleInfoDrop]");
            BindingTextBoxValue(BattleInfoBattleTimesTextBox, "[BattleInfoBattleTimes]");
            //TODO：BattleInfoMonsterList
            BindingTextBoxValue(BattleInfoMonsterNumTextBox, "[BattleInfoMonsterNum]");
            BindingTextBoxValue(BattleInfoDropItemIDTextBox, "[BattleInfoDropItemID]");
            BindingTextBoxValue(BattleInfoDropItemNumTextBox, "[BattleInfoDropItemNum]");
            //BindingTextBoxValue(ScenarioInfoAnimationIDTextBox, "[ScenarioInfoAnimationID]");
            //BindingTextBoxValue(ScenarioInfoBranchNpcIDTextBox, "[ScenarioInfoBranchNpcID]");
            //BindingTextBoxValue(ScenarioInfoBranchNoteTextBox, "[ScenarioInfoBranchNote]");
            //TODO：ScenarioInfoBranchOptionList
            //TODO：ScenarioInfoNpcConversationList
            //TODO：ScenarioInfoNpcID
            //TODO：ScenarioInfoFinishConversationList
            //TODO：ScenarioInfoFinishNpcID
        }

        private int GetSelectedRow()
        {
            if (MissionDataGrid != null && MissionDataGrid.SelectedCells.Count != 0)
            {
                return MissionDataGrid.SelectedIndex;
            }

            return -1;
        }

        private void BindingTextBoxValue(FrameworkElement textBox, string value)
        {
            textBox.SetBinding(TextBox.TextProperty, new Binding
            {
                Source = AssetManager.MissionDatatable.Rows[SelectDataRow],
                Path = new PropertyPath(value),
                Mode = BindingMode.TwoWay
            });
        }

        private void SaveButton_click(object sender, MouseButtonEventArgs e)
        {
            AssetManager.SaveExcel(WriteRows);
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs textCompositionEventArgs)
        {
            WriteRows.Add(SelectDataRow);
        }

        private void MissionDataGrid_OnCellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            WriteRows.Add(SelectDataRow);
        }

        private void ComboBox_OnSelectionChanged(object sender, RoutedEventArgs routedEventArgs)
        {
            WriteRows.Add(SelectDataRow);
        }
    }
}