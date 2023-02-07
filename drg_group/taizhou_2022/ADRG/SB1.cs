namespace drg_group.taizhou_2022{
    public class SB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合SB1入组条件，匹配规则：存在手术");
                    
                if (MDCS_DRG.SB19_group(record))
                {
                    return "SB19";
                }

                return "SB1";
            }else{
                return "";
            }
        }
    }
}