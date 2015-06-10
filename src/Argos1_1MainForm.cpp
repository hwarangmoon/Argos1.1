#include "Argos1_1MainForm.h"
#include "AppResourceId.h"

using namespace Tizen::Base;
using namespace Tizen::App;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;


Argos1_1MainForm::Argos1_1MainForm(void)
{
}

Argos1_1MainForm::~Argos1_1MainForm(void)
{
}

bool
Argos1_1MainForm::Initialize(void)
{
	result r = Construct(IDL_FORM);
	TryReturn(r == E_SUCCESS, false, "Failed to construct form");
	return true;
}

result
Argos1_1MainForm::OnInitializing(void)
{
	result r = E_SUCCESS;

	// TODO: Add your initialization code here

	// Setup back event listener
	SetFormBackEventListener(this);
	// Get a button via resource ID
	//Tizen::Ui::Controls::Button* pButtonOk = static_cast< Button* >(GetControl(IDC_BUTTON_OK));
	Tizen::Ui::Controls::Button* pButtonPerformance = static_cast< Button* >(GetControl(IDC_BUTTON_Performance));
	Tizen::Ui::Controls::Button* pButtonPowerSaving = static_cast< Button* >(GetControl(IDC_BUTTON_PowerSaving));
	//if (pButtonOk != null)
	//{
	//	pButtonOk->SetActionId(IDA_BUTTON_OK);
	//	pButtonOk->AddActionEventListener(*this);
	//}
	if (pButtonPerformance != null)
	{
		pButtonPerformance->SetActionId(IDA_BUTTON_Performance);
		pButtonPerformance->AddActionEventListener(*this);
	}
	if (pButtonPowerSaving != null)
	{
		pButtonPowerSaving->SetActionId(IDA_BUTTON_PowerSaving);
		pButtonPowerSaving->AddActionEventListener(*this);
	}

	return r;
}

result
Argos1_1MainForm::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO: Add your termination code here
	return r;
}

void
Argos1_1MainForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	FILE *fp=NULL;
	int num;
	//int written;
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(actionId)
	{
	//case IDA_BUTTON_OK:
	//	AppLog("XXX - OK Button is clicked!");
	//	break;
	case IDA_BUTTON_Performance:
		AppLog("XXX - Optimization Button is clicked!");
		fp = fopen("/sys/devices/argos.9/power_mode", "r+");
		if (fp < 0) {
			AppLog("XXX - Can't open file");
			break;
		}
		else if(fp==NULL){
			AppLog("XXX - Can't open file");
			break;
		}
		num = 1;
		//written = fwrite(&num, sizeof(int), sizeof(int), fp);
		fprintf(fp, "%d", num);
		fclose(fp);
		//sync();
		//AppLog("XXX - write: %d", written);
		break;
	case IDA_BUTTON_PowerSaving:
		AppLog("XXX - PowerSaving Button is clicked!");
		fp = fopen("/sys/devices/argos.9/power_mode", "r+");

		if (fp < 0) {
			AppLog("XXX - Can't open file");
			return;
		}
		else if(fp==NULL){
					AppLog("XXX - Can't open file");
					return;
		}
		num = 0;
		//written = fwrite(&num, sizeof(int), sizeof(int), fp);
		fprintf(fp, "%d", num);
		fclose(fp);
		//sync();
		//AppLog("XXX - write: %d", written);
		break;
	default:
		break;
	}

}

void
Argos1_1MainForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}

void
Argos1_1MainForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId,
										  const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
	// TODO: Activate your scene here.

}

void
Argos1_1MainForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
										   const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
	// TODO: Deactivate your scene here.

}

