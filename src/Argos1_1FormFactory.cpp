#include <new>
#include "Argos1_1FormFactory.h"
#include "Argos1_1MainForm.h"
#include "AppResourceId.h"

using namespace Tizen::Ui::Scenes;


Argos1_1FormFactory::Argos1_1FormFactory(void)
{
}

Argos1_1FormFactory::~Argos1_1FormFactory(void)
{
}

Tizen::Ui::Controls::Form*
Argos1_1FormFactory::CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Form* pNewForm = null;

	if (formId == IDL_FORM)
	{
		Argos1_1MainForm* pForm = new (std::nothrow) Argos1_1MainForm();
		TryReturn(pForm != null, null, "The memory is insufficient.");
		pForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pForm);
		pNewForm = pForm;
	}
	// TODO: Add your form creation code here

	return pNewForm;
}
