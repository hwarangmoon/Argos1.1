#include "Argos1_1PanelFactory.h"

using namespace Tizen::Ui::Scenes;


Argos1_1PanelFactory::Argos1_1PanelFactory(void)
{
}

Argos1_1PanelFactory::~Argos1_1PanelFactory(void)
{
}

Tizen::Ui::Controls::Panel*
Argos1_1PanelFactory::CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Panel* pNewPanel = null;

	// TODO: Add your panel creation code here
	return pNewPanel;
}
