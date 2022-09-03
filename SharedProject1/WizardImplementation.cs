using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;
using System.IO;

namespace TemplateModWizard
{
    public class WizardImplementation : IWizard
    {
        private Form1 inputForm;
        private string modAuthor;
        private string modDescription;
        private string targetType;
        private string targetMethod;
        
        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        { // Very important to me that the readme is always in the correct place on generate
            try
            {
                if (projectItem.Name != "README.md") return;
                
                Project project = projectItem.ContainingProject;
                Solution solution = project.DTE.Solution;

                if (String.IsNullOrEmpty(solution.FullName))
                {
                    projectItem.Remove();
                    return;
                }; //When you place solution and project in same folder
                
                string dir = Path.GetDirectoryName(solution.FullName);
                string origPath = Path.GetFullPath(projectItem.FileNames[0]);
                string newPath = Path.Combine(dir, "README.md");

                if (origPath == newPath) return;

                //BRRRRR
                /* Doing projectItem.Remove(); 
                 * then project.ProjectItems.AddFromFile(newPath);
                 * does not work correctly
                 */

                File.Copy(origPath, newPath, true);
                projectItem.Delete();
                project.ProjectItems.AddFromFile(newPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BeforeOpeningFile ERROR: \n\n" + ex.ToString());
            }
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
            /*MessageBox.Show("RunFinished ");
            try
            {
                //project.ProjectItems.Count

                MessageBox.Show("RunFinished " + Project.ProjectItems.Count);
                for (int i = 1; i <= Project.ProjectItems.Count; i++)
                {
                    ProjectItem item = Project.ProjectItems.Item(i);
                    MessageBox.Show(item.Name);
                    *//*if (item.Name != "README.md")
                    {
                        item.Remove();
                        MessageBox.Show("Removed " + item.Name);
                    }*//*
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RunFinished ERROR: \n\n" + ex.ToString());
            }*/
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects
                // input for the custom message.
                inputForm = new Form1();
                inputForm.ShowDialog();

                modAuthor = Form1.modAuthor;
                modDescription = Form1.modDescription;
                targetType = Form1.targetType;
                targetMethod = Form1.targetMethod;

                // Add custom parameters.
                replacementsDictionary.Add("$modauthor$",
                    modAuthor);
                replacementsDictionary.Add("$moddescription$",
                    modDescription);
                replacementsDictionary.Add("$targettype$",
                    targetType);
                replacementsDictionary.Add("$targetmethod$",
                    targetMethod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RunStarted ERROR: \n\n" + ex.ToString());
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}