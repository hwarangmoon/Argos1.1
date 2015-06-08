#include "Argos1_1Frame.h"
#include "Argos1_1FormFactory.h"
#include "Argos1_1PanelFactory.h"
#include "AppResourceId.h"

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;

Argos1_1Frame::Argos1_1Frame(void)
{
}

Argos1_1Frame::~Argos1_1Frame(void)
{
}

result
Argos1_1Frame::OnInitializing(void)
{
	// Prepare Scene management.
	SceneManager* pSceneManager = SceneManager::GetInstance();
	static Argos1_1FormFactory formFactory;
	static Argos1_1PanelFactory panelFactory;
	pSceneManager->RegisterFormFactory(formFactory);
	pSceneManager->RegisterPanelFactory(panelFactory);
	pSceneManager->RegisterScene(L"workflow");

	// Go to the scene.
	result r = pSceneManager->GoForward(SceneTransitionId(IDSCNT_MAIN_SCENE));

	// TODO: Add your frame initialization code here.
	return r;
}

result
Argos1_1Frame::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO: Add your frame termination code here.
	return r;
}
