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
	AppLog("XXX - 0");
	return true;
}

result
Argos1_1MainForm::OnInitializing(void)
{
	result r = E_SUCCESS;

	// TODO: Add your initialization code here

	// Setup back event listener
	SetFormBackEventListener(this);
	AppLog("XXX - 1");
	// Get a button via resource ID
	Tizen::Ui::Controls::Button* pButtonOk = static_cast< Button* >(GetControl(IDC_BUTTON_OK));
	Tizen::Ui::Controls::Button* pButtonOptimization = static_cast< Button* >(GetControl(IDC_BUTTON_Optimization));
	Tizen::Ui::Controls::Button* pButtonPowerSaving = static_cast< Button* >(GetControl(IDC_BUTTON_PowerSaving));
	if (pButtonOk != null)
	{
		pButtonOk->SetActionId(IDA_BUTTON_OK);
		pButtonOk->AddActionEventListener(*this);
	}
	if (pButtonOptimization != null)
	{
		pButtonOptimization->SetActionId(IDA_BUTTON_Optimization);
		pButtonOptimization->AddActionEventListener(*this);
	}
	if (pButtonPowerSaving != null)
	{
		pButtonPowerSaving->SetActionId(IDA_BUTTON_PowerSaving);
		pButtonPowerSaving->AddActionEventListener(*this);
	}
	AppLog("XXX - 2");

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
	FILE *fp;
	int num;
	int written;
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(actionId)
	{
	case IDA_BUTTON_OK:
		AppLog("XXX - OK Button is clicked!");
		break;
	case IDA_BUTTON_Optimization:
			AppLog("XXX - Optimization Button is clicked!");
			fp = fopen("/sys/module/argos/parameters/power_mode", "r+");
			if (fp < 0) {
				AppLog("XXX - Can't open file");
				return;
			}

			num = 1;
			written = fwrite(&num, sizeof(int), sizeof(int), fp);
			AppLog("XXX - writte: %d", written);
			break;
	case IDA_BUTTON_PowerSaving:
			AppLog("XXX - PowerSaving Button is clicked!");
			fp = fopen("/sys/module/argos/parameters/power_mode", "r+");
			if (fp < 0) {
				AppLog("XXX - Can't open file");
				return;
			}
			num = 0;
			written = fwrite(&num, sizeof(int), sizeof(int), fp);
			AppLog("XXX - writte: %d", written);
			break;
	default:
		break;
	}
	fclose(fp);
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

