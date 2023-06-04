using System;
using System.Collections.Generic;

namespace Bottleneck.UI
{
    public static class Strings
    {
        public static string BottleneckString(this string s, Language language = Language.enUS)
        {
            if (s == null)
            {
                return "";
            }
            if (_strings.TryGetValue(s, out string result))
            {
                return result;
            }
            return s;
        }

        internal static Dictionary<string, string> _strings = new();
        internal static void AddToDictionary(params string[] ary)
        {
            if (ary.Length >= 2)
            {
                _strings.Add(ary[0], ary[1]);
            }
        }
        public static void Init()
        {
            AddToDictionary("clearFilterLabel", "Clear filter", "清除筛选器");
            AddToDictionary("localSystemLabel", "Local System", "本地系统");

            // The Chinese display here is /min, so there is no need to translate here, /sec too.
            AddToDictionary("perMinLabel", "/min", "/min");
            AddToDictionary("perSecLabel", "/sec", "/sec");

            AddToDictionary("dispPerSecLabel", "Display /sec", "以 /秒 显示");
            AddToDictionary("filterLabel", "Filter", "筛选");

            AddToDictionary("consumersLabel", "Consumers", "消耗设施");
            AddToDictionary("producersLabel", "Producers", "生产设施");
            AddToDictionary("theoreticalMaxLabel", "Theoretical max", "理论最大值", "Maximum théorique");

            AddToDictionary("prodDetailsLabel", "Production Details", "生产详情", "Détails de fabrication");
            AddToDictionary("clickPrecursorText", " (click to show only precursor items)", "（鼠标单击 仅展示所有前置材料）");
            AddToDictionary("controlClickLacking", "(Control click see only precursors that are lacking)\r\n", "（按住Ctrl+鼠标单击 仅展示产量不足的前置材料）\r\n");
            AddToDictionary("producedOnLabel", "Produced on", "生产于");

            AddToDictionary("conDetailsLabel", "Consumption Details", "消耗详情", "Détails de la consommation");
            AddToDictionary("clickConsumingText", " (click to show only consuming items)", "（鼠标单击 仅展示用于制作的物品）");
            AddToDictionary("consumedOnLabel", "Consumed on", "消耗于");

            // text used in bottleneck message for an item
            AddToDictionary("needLabel", "Need", "需要");
            AddToDictionary("currentLabel", "current", "当前");
            AddToDictionary("stackingLabel", "Stacking", "产物堆积");
            AddToDictionary("underPoweredLabel", "Under Powered", "电力不足");
            AddToDictionary("missingSprayLabel", "Missing spray", "缺少增产剂");
            AddToDictionary("bottlenecksLabel", "Bottlenecks", "瓶颈");
            // text used in proliferator selection
            AddToDictionary("proliferatorCalcDisabledLabel", "Proliferator Calculation Disabled", "增产剂计算已禁用");
            AddToDictionary("proliferatorCalcDisabledHover", "Don't use Proliferator Points for calculation of Theoretical max values", "不使用增产点数计算理论最大值");
            AddToDictionary("proliferatorCalcEnabledLabel", "Proliferator Calculation Enabled", "增产剂计算已启用");

            AddToDictionary("assemblerSelection", "Assembler Selection Mode", "生产设施当前选择 模式");
            AddToDictionary("assemblerSelectionHover", "Max values calculated using currently selected mode for each assembler.", "使用每个生产设施 当前选择 的模式计算理论最大值");

            AddToDictionary("forceProductivity", "Force Productivity Mode", "强制 额外产出 模式");
            AddToDictionary("forceProductivityHover", "Max values calculated as if all all assemblers were set to 'Extra Products'.", "假设每个生产设施使用 额外产出 模式计算理论最大值");

            AddToDictionary("forceSpeed", "Force Speed Mode", "强制 生产加速 模式");
            AddToDictionary("forceSpeedHover", "Max values calculated as if all all assemblers were set to 'Production Speedup'.", "假设每个生产设施使用 生产加速 模式计算理论最大值");

            AddToDictionary("recipePreText", "Recipe", "配方");
        }

        public static string NeedLabel => "needLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string CurrentLabel => "currentLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string StackingLabel => "stackingLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string UnderPoweredLabel => "underPoweredLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string MissingSprayLabel => "missingSprayLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string BottlenecksLabel => "bottlenecksLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string ProliferatorCalculationDisabled => "proliferatorCalcDisabledLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string ProliferatorCalculationDisabledHover => "proliferatorCalcDisabledHover".BottleneckString(PluginConfig.GetLanguage());
        public static string ProliferatorCalculationEnabled => "proliferatorCalcEnabledLabel".BottleneckString(PluginConfig.GetLanguage());
        public static string AssemblerSelectionMode => "assemblerSelection".BottleneckString(PluginConfig.GetLanguage());
        public static string AssemblerSelectionHover => "assemblerSelectionHover".BottleneckString(PluginConfig.GetLanguage());
        public static string ForceProductivityMode => "forceProductivity".BottleneckString(PluginConfig.GetLanguage());
        public static string ForceProductivityHover => "forceProductivityHover".BottleneckString(PluginConfig.GetLanguage());
        public static string ForceSpeedMode => "forceSpeed".BottleneckString(PluginConfig.GetLanguage());
        public static string ForceSpeedModeHover => "forceSpeedHover".BottleneckString(PluginConfig.GetLanguage());
        public static string RecipePreText => "recipePreText".BottleneckString(PluginConfig.GetLanguage());
    }
}
