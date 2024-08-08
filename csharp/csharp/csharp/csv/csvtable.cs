namespace ngl
{
	public enum ENET_CONFIG
	{
		net_config_send_buff_maxbyte = 8129,	
		net_config_recv_buff_maxbyte = 8129,	
		net_config_logic_pthread_max_size = 8,	
		net_config_socket_pthread_max_size = 8,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ENET_CONFIG> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ENET_CONFIG)ltemp);
			}
			return true;
		}
	}
	public enum EUDP_OPERATOR
	{
		EUDP_OPERATOR_ACK,	// ȷ�ϰ�
		EUDP_OPERATOR_DATA,	// ���������ݰ�
		EUDP_OPERATOR_HEARTBEAT,	// ������Ҫ����ȷ�϶Զ��Ƿ�����
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EUDP_OPERATOR> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EUDP_OPERATOR)ltemp);
			}
			return true;
		}
	}
	public enum EPH_HEAD_VAL
	{
		EPH_HEAD_MASK_SUCCESS = 1,	// MASKһ��
		EPH_HEAD_MASK_FAIL = 2,	// MASK��һ��
		EPH_HEAD_FOLLOW = 3,	// ��ͷ����û�н������
		EPH_HEAD_SUCCESS = 4,	// ��ͷ�����ѽ������
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EPH_HEAD_VAL> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EPH_HEAD_VAL)ltemp);
			}
			return true;
		}
	}
	public enum EPH
	{
		EPH_MASK_VALUE = 0xff,	
		EPH_MASK_COUNT = 2,	
		EPH_MASK = 0,	// ����ȷ���Ƿ�ʹ�ð�
		EPH_BYTES = EPH_MASK_COUNT,	// Э���ֽ���
		EPH_TIME,	// ���Ͷ˵�ʱ���
		EPH_PROTOCOLNUM,	// Э���
		EPH_PROTOCOLTYPE,	// Э������ EPROTOCOL_TYPE
		EPH_ACTOR_TYPEAREA,	// ACTOR_TYPE_AREA
		EPH_ACTOR_ID,	// ACTOR_ID
		EPH_REQUEST_ACTOR_TYPEAREA,	// Request REQUEST_ACTOR_TYPE_AREA
		EPH_REQUEST_ACTOR_ID,	// Request ACTOR_ID
		EPH_SUM,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EPH> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EPH)ltemp);
			}
			return true;
		}
	}
	public enum NODE_TYPE
	{
		DB = 1,	// ���ݿ������
		ACTORSERVER = 2,	// actor ������
		GAME = 3,	// �߼�������
		GATEWAY = 4,	// ���ط�����
		LOGIN = 5,	// ��¼������
		ROBOT = 6,	// ���Ի����˷�����
		WORLD = 7,	// ���������
		LOG = 8,	// ��־������
		RELOADCSV = 9,	// ���طַ�csv������
		CROSS = 10,	// ���������
		CROSSDB = 11,	// ������ݿ������
		PUSHSERVERCONFIG = 12,	// �������������ϴ�lbgmsys
		FAIL = -1,	// ���������ʹ���
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<NODE_TYPE> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((NODE_TYPE)ltemp);
			}
			return true;
		}
	}
	public enum ENET_PROTOCOL
	{
		ENET_NULL = -1,	
		ENET_TCP = 0,	
		ENET_WS = 1,	
		ENET_KCP = 2,	
		ENET_COUNT = 3,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ENET_PROTOCOL> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ENET_PROTOCOL)ltemp);
			}
			return true;
		}
	}
	public enum EnumModule
	{
		E_ModuleNull = 0,	// ��	
		E_ModuleRoot = 1,	// ����(��β)
		E_ModuleBuff = 2,	// ���buff
		E_ModuleEquip = 3,	// װ��
		E_ModuleEquipWeapon = 4,	// װ������
		E_ModuleEquipHelmet = 5,	// װ��ͷ��
		E_ModuleEquipCloth = 6,	// װ���·�
		E_ModuleEquipPants = 7,	// װ������
		E_ModuleCount = 8,	// ���� 	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EnumModule> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EnumModule)ltemp);
			}
			return true;
		}
	}
	public enum EnumAttribute
	{
		E_Attack,	// [����]
		E_Defense,	// [����]
		E_Hp,	// [Ѫ��]
		E_Anger,	// [ŭ��]
		E_Speed,	// [�ٶ�]
		E_Count,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EnumAttribute> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EnumAttribute)ltemp);
			}
			return true;
		}
	}
	public enum EItemSrc
	{
		EItemSrcNoraml = 0,	
		EItemSrcGM = 1,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EItemSrc> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EItemSrc)ltemp);
			}
			return true;
		}
	}
	public enum EItemConsume
	{
		EItemConsumeNoraml = 0,	
		EItemConsumeGM = 1,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EItemConsume> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EItemConsume)ltemp);
			}
			return true;
		}
	}
	public enum EItemType
	{
		EEquipment = 1,	// װ��
		EMaterial = 2,	// ����
		EMoneyGold = 3,	// ���
		EMoneySilver = 4,	// ����
		ECard = 5,	// ����
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EItemType> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EItemType)ltemp);
			}
			return true;
		}
	}
	public enum EQuality
	{
		EQualityGrey = 0,	//��ɫ
		EQualityGreen = 1,	//��ɫ
		EQualityYellow = 2,	//��ɫ
		EQualityOrange = 3,	//��ɫ
		EQualityRed = 4,	//��ɫ
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EQuality> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EQuality)ltemp);
			}
			return true;
		}
	}
	public enum EEquip
	{
		EEquipWeapon = 1,	// ����
		EEquipHelmet = 2,	// ͷ��
		EEquipCloth = 3,	// �·�
		EEquipPants = 4,	// ����
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EEquip> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EEquip)ltemp);
			}
			return true;
		}
	}
	public enum ECalendar
	{
		Week = 0,	// �ܼ�
		ServerOpen = 1,	// �Կ���ʱ������������
		RegularSlot = 2,	// �̶�ʱ���
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ECalendar> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ECalendar)ltemp);
			}
			return true;
		}
	}
	public enum ECalendarType
	{
		ECalendarTypeEveryDay,	// ÿ�ն�ʱˢ��
		ECalendarTypeActivity,	// �������ر�
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ECalendarType> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ECalendarType)ltemp);
			}
			return true;
		}
	}
	public enum EActivity
	{
		EActivityDrawCompliance = 1,	// ��������֮����<<��ļ���>>
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<EActivity> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((EActivity)ltemp);
			}
			return true;
		}
	}
	public enum ETask
	{
		ETaskRoleLv = 0,	// ��ҵȼ�
		ETaskRoleVip = 1,	// ���vip�ȼ�
		ETaskTaskId = 2,	// ���ĳID����
		ETaskCount,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ETask> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ETask)ltemp);
			}
			return true;
		}
	}
	public enum ETaskCondition
	{
		ETaskConditionMore = 0,	// ���ڵ���
		ETaskConditionLess = 1,	// С�ڵ���
		ETaskConditionEqual = 2,	// ����
		ETaskConditionCount,	
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ETaskCondition> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ETaskCondition)ltemp);
			}
			return true;
		}
	}
	public enum ETaskType
	{
		ETaskTypePrincipalLine,	// ��������
		ETaskTypeBranchLine,	// ֧������
		ETaskTypeDaily,	// ÿ������
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<ETaskType> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((ETaskType)ltemp);
			}
			return true;
		}
	}
	public enum eobstacles
	{
		eobstacles_pass = 0,	// ����ͨ��
		eobstacles_nopass = 1,	// �޷�ͨ��
	}
	partial class RCsv
	{
		public static bool ReadCsv(CsvPair apair, List<eobstacles> avec)
		{
			string ltempstr = Read(apair);
			CsvPair lpair = new CsvPair();
			lpair.m_data = ltempstr;
			lpair.m_fg = '*';
			for (; !IsOk(lpair);)
			{
				Int32 ltemp = 0;
				if (ReadCsv(lpair, ref ltemp))
					avec.Add((eobstacles)ltemp);
			}
			return true;
		}
	}
	class net_works : ICsvRead
	{
		/*********************************/
		public ENET_PROTOCOL		m_type;		
		public string		m_ip;		
		public string		m_nip;		
		public UInt16		m_port;		
		/*********************************/
		public bool Read(CsvPair apair)
		{
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (ENET_PROTOCOL)lm_type;
			if(RCsv.ReadCsv(apair, ref m_ip) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_nip) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_port) == false)
				return false;
			return true;
		}
	}
	class tab_servers : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int16		m_area;		// [index:3][load:y] ����
		public NODE_TYPE		m_type;		// [index:4][load:y] ����������(1db2actorserver3game4gateway5login6robot7world8log9reloadcsv10reloadcsv_tools)
		public Int32		m_tcount;		// [index:5][load:y] ͬ���ͷ����������
		public Int32		m_threadnum;		// [index:6][load:y] socket�߳���
		public Int32		m_actorthreadnum;		// [index:7][load:y] actor�̳߳��߳���
		public bool		m_outernet;		// [index:8][load:y] �Ƿ�������������
		public Int32		m_db;		// [index:9][load:y] ���ӵ�db����id
		public Int32		m_reloadcsv;		// [index:10][load:y] ���ӵ�reloadcsv����id
		public Int32		m_login;		// [index:11][load:y] ���ӵ�login����id
		public Int16		m_crossarea;		// [index:12][load:y] �������
		public List<Int32>		m_actorserver = new List<Int32>();		// [index:13][load:y] ���ӵ�actorserver����id(�����Ҫ��д���actorserver)
		public List<net_works>		m_net = new List<net_works>();		// [index:14][load:y] �������������(net_works:m_type(0tcp1ws2kcp),m_ip,m_nip,m_port)
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_area) == false)
				return false;
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (NODE_TYPE)lm_type;
			if(RCsv.ReadCsv(apair, ref m_tcount) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_threadnum) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_actorthreadnum) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_outernet) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_db) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_reloadcsv) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_login) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_crossarea) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_actorserver) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_net) == false)
				return false;
			return true;
		}
	}
	class tab_dbload : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public bool		m_isloadall;		// [index:3][load:y] �Ƿ���Ҫ��������ȫ������
		public bool		m_network;		// [index:4][load:y] �Ƿ�����ͨ������ַ�
		public Int32		m_sendmaxcount;		// [index:5][load:y] ������෢������
		public Int32		m_dbcacheintervalms;		// [index:6][load:y] ���ݻ��������
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_isloadall) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_network) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_sendmaxcount) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_dbcacheintervalms) == false)
				return false;
			return true;
		}
	}
	class tab_errormessage : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public string		m_message;		// [index:3][load:y] ��������
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_message) == false)
				return false;
			return true;
		}
	}
	class tab_specialid : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1[load:y]] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public string		m_value;		// [index:3][load:y] ֵ
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_value) == false)
				return false;
			return true;
		}
	}
	class tab_attribute : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public float		m_fightcoefficient;		// [index:3][load:y] �����ṩ��ս��ϵ��
		public Int32		m_initvalue;		// [index:4][load:y] ���Գ�ʼֵ
		public Int32		m_uplimit;		// [index:5][load:y] ����
		public Int32		m_lowlimit;		// [index:6][load:y] ����
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_fightcoefficient) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_initvalue) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_uplimit) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_lowlimit) == false)
				return false;
			return true;
		}
	}
	class tab_item : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_ranks;		// [index:3][load:y] ����ֵ
		public EItemType		m_type;		// [index:4][load:y] ��Ʒ����EItemType(1װ��,2����,3���,4����)
		public Int32		m_quality;		// [index:5][load:y] ��ƷƷ��(EQuality)
		public bool		m_isstack;		// [index:6][load:y] �Ƿ�ɶѵ�
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_ranks) == false)
				return false;
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (EItemType)lm_type;
			if(RCsv.ReadCsv(apair, ref m_quality) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_isstack) == false)
				return false;
			return true;
		}
	}
	class attributevalue : ICsvRead
	{
		/*********************************/
		public Int32		m_id;		// ����id(EnumAttribute)
		public bool		m_isratio;		// �Ƿ���ֱ�����
		public Int32		m_value;		// ����ֵ
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_isratio) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_value) == false)
				return false;
			return true;
		}
	}
	class tab_equip : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public EEquip		m_position;		// [index:3][load:y] ��λEEquip(1����2ͷ��3�·�4����)
		public List<attributevalue>		m_attributevalues = new List<attributevalue>();		// [index:4][load:y] װ������
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			Int32 lm_position = 0;
			if(RCsv.ReadCsv(apair, ref lm_position) == false)
				return false;
			m_position = (EEquip)lm_position;
			if(RCsv.ReadCsv(apair, m_attributevalues) == false)
				return false;
			return true;
		}
	}
	class tab_equiplv : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_consume;		// [index:3][load:y] ��������id
		public List<attributevalue>		m_attributevalues = new List<attributevalue>();		// [index:4][load:y] װ������
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_consume) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_attributevalues) == false)
				return false;
			return true;
		}
	}
	class tab_card : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public EQuality		m_quality;		// [index:3][load:y] Ʒ��EQuality(0��ɫ1��ɫ2��ɫ3��ɫ4��ɫ)
		public List<attributevalue>		m_attributevalues = new List<attributevalue>();		// [index:4][load:y] ����
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			Int32 lm_quality = 0;
			if(RCsv.ReadCsv(apair, ref lm_quality) == false)
				return false;
			m_quality = (EQuality)lm_quality;
			if(RCsv.ReadCsv(apair, m_attributevalues) == false)
				return false;
			return true;
		}
	}
	class trandom : ICsvRead
	{
		/*********************************/
		public Int32		m_id;		
		public Int32		m_min;		
		public Int32		m_max;		
		public Int32		m_weight;		
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_min) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_max) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_weight) == false)
				return false;
			return true;
		}
	}
	class tab_random : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public List<trandom>		m_randomdatas = new List<trandom>();		// [index:3][load:y] trandom(id*min*max*weight)
		public bool		m_exclusive;		// [index:4][load:y] �����Զ�ε���ʱʹ�ã�true���������ѵ�����Ʒ false�������ѵ�����Ʒ��
		public Int32		m_count;		// [index:5][load:y] �������
		public Int32		m_calendarids;		// [index:6][load:y] �Ƿ����������,ֻ�����������Ż�ִ�д˵���
		public List<Int32>		m_childrandomids = new List<Int32>();		// [index:7][load:y] �����
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_randomdatas) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_exclusive) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_count) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_calendarids) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_childrandomids) == false)
				return false;
			return true;
		}
	}
	class tconsume : ICsvRead
	{
		/*********************************/
		public Int32		m_tid;		
		public Int32		m_count;		
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_tid) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_count) == false)
				return false;
			return true;
		}
	}
	class tab_consume : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public List<tconsume>		m_consumeitems = new List<tconsume>();		// [index:3][load:y] tid*count
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_consumeitems) == false)
				return false;
			return true;
		}
	}
	class tab_synthesis : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_consume;		// [index:3][load:y] �����б�
		public Int32		m_generate;		// [index:4][load:y] �����(tab_rando)id ����ɹ���Ʒ�б�
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_consume) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_generate) == false)
				return false;
			return true;
		}
	}
	class tweek : ICsvRead
	{
		/*********************************/
		public Int32		m_weekstart;		// �ܼ���ʼ
		public string		m_opentime;		// ����ʱ�� HH:mm:ss
		public Int32		m_weekfinish;		// �ܼ�����
		public string		m_closetime;		// ����ʱ�� HH:mm:ss
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_weekstart) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_opentime) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_weekfinish) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_closetime) == false)
				return false;
			return true;
		}
	}
	class tserveropen : ICsvRead
	{
		/*********************************/
		public Int32		m_beg;		// ����������쿪��
		public string		m_opentime;		// ����ʱ�� HH:mm:ss
		public Int32		m_end;		// ��������������
		public string		m_closetime;		// ����ʱ�� HH:mm:ss
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_beg) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_opentime) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_end) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_closetime) == false)
				return false;
			return true;
		}
	}
	class tregularslot : ICsvRead
	{
		/*********************************/
		public string		m_opentime;		// ����ʱ�� YYYY-MM-DD HH:mm:ss
		public string		m_closetime;		// ����ʱ�� YYYY-MM-DD HH:mm:ss
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_opentime) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_closetime) == false)
				return false;
			return true;
		}
	}
	class tab_calendar : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public ECalendar		m_type;		// [index:3][load:y] ECalendar(0:�ܼ�,1:�Կ���ʱ������������,2:�̶�ʱ���)
		public List<tweek>		m_week = new List<tweek>();		// [index:4][load:y] m_type=0,tweek(�ܼ���ʼ(1-7)*����ʱ��HH:mm:ss*�ܼ�����(1-7)*����ʱ��HH:mm:ss)
		public List<tserveropen>		m_serveropen = new List<tserveropen>();		// [index:5][load:y] m_type=1,tserveropen(����������쿪��*����ʱ��HH:mm:ss*��������������*����ʱ��HH:mm:ss)
		public List<tregularslot>		m_tregularslot = new List<tregularslot>();		// [index:6][load:y] m_type=2,tregularslot(����ʱ��YYYY/MM/DD HH:mm:ss*����ʱ��YYYY/MM/DD HH:mm:ss)
		public ECalendarType		m_carendar;		// [index:7][load:y] (0.ÿ�ն�ʱˢ��1.�������ر�)
		public List<Int32>		m_carendarparm = new List<Int32>();		// [index:8][load:y] (m_carendar == ECalendarTypeActivity:�id)
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (ECalendar)lm_type;
			if(RCsv.ReadCsv(apair, m_week) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_serveropen) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_tregularslot) == false)
				return false;
			Int32 lm_carendar = 0;
			if(RCsv.ReadCsv(apair, ref lm_carendar) == false)
				return false;
			m_carendar = (ECalendarType)lm_carendar;
			if(RCsv.ReadCsv(apair, m_carendarparm) == false)
				return false;
			return true;
		}
	}
	class tab_mail : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public string		m_title;		// [index:3][load:y] �ʼ�����
		public string		m_author;		// [index:4][load:y] �ʼ�����
		public string		m_content;		// [index:5][load:y] �ʼ�����
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_title) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_author) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_content) == false)
				return false;
			return true;
		}
	}
	class tab_chat : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_time;		// [index:3][load:y] ���췢�Լ��
		public Int32		m_count;		// [index:4][load:y] ���췢���������
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_time) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_count) == false)
				return false;
			return true;
		}
	}
	class tab_activity : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public EActivity		m_type;		// [index:3][load:y] �����(1��������֮����<<��ļ���>>)
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (EActivity)lm_type;
			return true;
		}
	}
	class tab_activity_drawcompliance : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_dropid;		// [index:3][load:y] ����id
		public Int32		m_mailid;		// [index:4][load:y] �ʼ�id
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_dropid) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_mailid) == false)
				return false;
			return true;
		}
	}
	class task_condition : ICsvRead
	{
		/*********************************/
		public ETask		m_type;		// ETask(0.��ҵȼ��ﵽX 1.����vip�ȼ��ﵽx 2.���ĳID����)
		public ETaskCondition		m_condition;		
		public Int32		m_parmint;		
		/*********************************/
		public bool Read(CsvPair apair)
		{
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (ETask)lm_type;
			Int32 lm_condition = 0;
			if(RCsv.ReadCsv(apair, ref lm_condition) == false)
				return false;
			m_condition = (ETaskCondition)lm_condition;
			if(RCsv.ReadCsv(apair, ref m_parmint) == false)
				return false;
			return true;
		}
	}
	class tab_task : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public ETaskType		m_type;		// [index:3][load:y] 
		public List<task_condition>		m_taskreceive = new List<task_condition>();		// [index:4][load:y] ���մ������ǰ��(ETask(0.��ҵȼ��ﵽX 1.����vip�ȼ��ﵽx 2.���ĳID����)*ETaskCondition(0.���ڵ���1.С�ڵ���2.����)*int32_t(ֵ))
		public List<task_condition>		m_taskcomplete = new List<task_condition>();		// [index:5][load:y] ��ɴ����������(ETask(0.��ҵȼ��ﵽX 1.����vip�ȼ��ﵽx 2.���ĳID����)*ETaskCondition(0.���ڵ���1.С�ڵ���2.����)*int32_t(ֵ))
		public Int32		m_dropid;		// [index:6][load:y] ������
		public bool		m_autoreceive;		// [index:7][load:y] �Ƿ��Զ���ȡ
		public Int32		m_mailid;		// [index:8][load:y] �Զ���ȡ���Ƿ����ʼ����ʼ�id(�Զ���ȡ���ʼ�id:m_autoreceive == true,��m_autoreceiveΪture����Ϊ-1)
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			Int32 lm_type = 0;
			if(RCsv.ReadCsv(apair, ref lm_type) == false)
				return false;
			m_type = (ETaskType)lm_type;
			if(RCsv.ReadCsv(apair, m_taskreceive) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_taskcomplete) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_dropid) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_autoreceive) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_mailid) == false)
				return false;
			return true;
		}
	}
	class obstacles_data : ICsvRead
	{
		/*********************************/
		public List<eobstacles>		m_data = new List<eobstacles>();		
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, m_data) == false)
				return false;
			return true;
		}
	}
	class tab_map : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_w;		// [index:3][load:y] x����
		public Int32		m_l;		// [index:4][load:y] y�᳤��
		public Int32		m_nx;		// [index:5][load:y] [��Ұ]x���������
		public Int32		m_ny;		// [index:6][load:y] [��Ұ]y���������
		public Int32		m_obstaclenx;		// [index:7][load:y] [Ѱ·]x���������
		public Int32		m_obstacleny;		// [index:8][load:y] [Ѱ·]y���������
		public List<obstacles_data>		m_obstacles = new List<obstacles_data>();		// [index:9][load:y] ��ͼ����
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_w) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_l) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_nx) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_ny) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_obstaclenx) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_obstacleny) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_obstacles) == false)
				return false;
			return true;
		}
	}
	class tab_matching : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_count;		// [index:3][load:y] �淨�ﵽ���������Կ����淨
		public Int32		m_time;		// [index:4][load:y] ƥ���ʱ��
		public bool		m_iswaitconfirm;		// [index:5][load:y] �Ƿ���Ҫ�ȴ�ȷ��
		public Int32		m_waitconfirmtime;		// [index:6][load:y] �ȴ�ȷ�ϵ�ʱ��
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_count) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_time) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_iswaitconfirm) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_waitconfirmtime) == false)
				return false;
			return true;
		}
	}
	class Vector2 : ICsvRead
	{
		/*********************************/
		public Int32		m_x;		
		public Int32		m_y;		
		/*********************************/
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_x) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_y) == false)
				return false;
			return true;
		}
	}
	class tab_plays : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_type;		// [index:3][load:y] �淨���� pbnet::eplays
		public Int32		m_mapid;		// [index:4][load:y] ���ĸ���ͼӦ�ø��淨
		public Int32		m_preparation_tm;		// [index:5][load:y] ׼���׶�ʱ��
		public Int32		m_play_tm;		// [index:6][load:y] �淨ʱ��
		public Int32		m_settlement_tm;		// [index:7][load:y] ����ʱ��
		public List<Vector2>		m_birthpoint = new List<Vector2>();		// [index:8][load:y] ������Vector2(m_x:int32_t,m_y:int32_t)	
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_type) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_mapid) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_preparation_tm) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_play_tm) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_settlement_tm) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_birthpoint) == false)
				return false;
			return true;
		}
	}
	class tab_recharge : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] id 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_price;		// [index:3][load:y] �۸�
		public Int32		m_gold;		// [index:4][load:y] ��õĽ������
		public Int32		m_bonus;		// [index:5][load:y] �����Ľ������
		public Int32		m_firstbonus;		// [index:6][load:y] �׳佱���Ľ������
		public Int32		m_dropid;		// [index:7][load:y] ����
		public Int32		m_vipexp;		// [index:8][load:y] ��ֵ�õ�λ���͵�vip����
		public Int32		m_count;		// [index:9][load:y] �Ƿ����Ƴ�ֵ����
		public List<Int32>		m_activityid = new List<Int32>();		// [index:10][load:y] ����ָ�������ʱ���ܳ�ֵ��һ��
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_price) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_gold) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_bonus) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_firstbonus) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_dropid) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_vipexp) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_count) == false)
				return false;
			if(RCsv.ReadCsv(apair, m_activityid) == false)
				return false;
			return true;
		}
	}
	class tab_familylv : ICsvRead, ICsv
	{
		/*********************************/
		public Int32		m_id;		// [index:0][load:y] ���ŵȼ� 
		public string		m_name;		// [index:1][load:y] ���� 
		public string		m_remarks;		// [index:2][load:n] ��ע
		public Int32		m_exp;		// [index:3][load:y] ������Ҫ�ľ���
		public Int32		m_maxmembers;		// [index:4][load:y] ����������
		/*********************************/
		public Int32 Id(){return m_id;}
		public bool Read(CsvPair apair)
		{
			if(RCsv.ReadCsv(apair, ref m_id) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_name) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_remarks) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_exp) == false)
				return false;
			if(RCsv.ReadCsv(apair, ref m_maxmembers) == false)
				return false;
			return true;
		}
	}
}
