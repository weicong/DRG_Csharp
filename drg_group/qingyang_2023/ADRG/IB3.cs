namespace drg_group.qingyang_2023{
    public class IB3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"03.0100x001","03.0200","03.0900x003","03.0900x004","03.0900x005","03.0900x006","03.0900x007","03.0900x009","03.0900x010","03.0900x014","03.0900x016","03.0900x019","03.0900x021","03.0900x022","03.0900x023","03.0900x024","03.0900x025","03.0900x026","03.0900x027","03.0900x028","03.0901","03.0902","03.0903","03.0904","03.0905","03.0906","03.0907","03.0908","03.0909","03.0910","03.0911","03.0912","03.0913","03.0914","03.0915","03.1x00x001","03.1x01","03.2100x001","03.2900x005","03.2901","03.2902","03.2903","03.3100x001","03.3101","03.3201","03.3202","03.4x00x001","03.4x00x002","03.4x00x007","03.4x00x008","03.4x00x009","03.4x01","03.4x03","03.4x03","03.4x04","03.4x05","03.4x06","03.4x07","03.4x07","03.5100x003","03.5300x001","03.5301","03.5302","03.5303","03.5304","03.5305","03.5900x005","03.5901","03.5902","03.5903","03.5905","03.6x00x008","03.6x01","03.6x02","03.6x03","03.7101","03.8x01","03.9000x001","03.9100x004","03.9101","03.9102","03.9200x001","03.9201","03.9202","03.9600","03.9900x003","03.9900x004","54.4x00x047","77.0904","77.1900x004","77.1904","77.2900x004","77.2904","77.3908","77.6900x032","77.6900x039","77.6900x055","77.6900x056","77.6904","77.6905","77.6906","77.7900x005","77.8900x008","77.8900x013","77.8905","77.8906","77.8907","77.8908","77.9900x004","77.9904","77.9905","77.9906","78.0900x008","78.0900x009","78.0900x010","78.0900x011","78.0900x013","78.0900x015","78.0900x018","78.0900x019","78.0904","78.1900x004","78.4904","78.5900x022","78.5900x026","78.5900x037","78.5904","78.7904","79.7900x003","79.7900x006","79.8900x002","79.8900x003","79.8900x006","79.8900x007","79.8900x009","79.8900x010","80.0900x001","80.4900x002","80.4901","80.4902","80.5100x008","80.5100x011","80.5100x013","80.5100x023","80.5100x024","80.5100x025","80.5100x026","80.5100x027","80.5100x028","80.5100x029","80.5100x030","80.5100x031","80.5100x032","80.5100x033","80.5100x034","80.5100x035","80.5100x036","80.5100x037","80.5100x038","80.5100x039","80.5101","80.5102","80.5103","80.5104","80.5105","80.5106","80.5107","80.5108","80.5109","80.5110","80.5111","80.5200","80.5300","80.5400x001","80.5401","80.7901","81.6500","81.6600x001","81.6600x002","81.6600x003","81.6601","84.5900x002","84.6001","84.6101","84.6201","84.6300x002","84.6300x003","84.6301","84.6400x001","84.6400x003","84.6401","84.6501","84.6600x001","84.6601","84.6700x002","84.6701","84.6800x001","84.6801","84.8001","84.8002","84.8100","84.8201","84.8202","84.8203","84.8204","84.8205","84.8301","84.8401","84.8402","84.8500","86.9401","86.9402","86.9500x001","86.9500x002","86.9600x003","86.9701","86.9702","86.9800x001","86.9800x002"};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IB3入组条件，匹配规则：主手术匹配");
                
                    
                if (MDCI_DRG.IB33_group(record))
                {
                    return "IB33";
                }
    
                if (MDCI_DRG.IB35_group(record))
                {
                    return "IB35";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}