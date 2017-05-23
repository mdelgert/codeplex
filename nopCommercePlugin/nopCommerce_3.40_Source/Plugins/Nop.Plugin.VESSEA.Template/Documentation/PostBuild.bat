http://stackoverflow.com/questions/12727631/how-to-configure-post-build-events-for-setup-deployment-projects-in-visual-studi

/Q : Quiet | Don't display files being copied

/E : Recursive ( copy subfolder structure and files )

/I : Consider that destination is a folder if it does not already exist (will create a new folder if required)

XCOPY "$(SolutionDir)Plugins\$(ProjectName)\Views" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\Views" /Q /E /I & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\Web.config" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\Web.config" & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\bin\$(ProjectName).dll" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\$(ProjectName).dll" & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\bin\$(ProjectName).dll.config" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\$(ProjectName).dll.config" & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\Description.txt" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\Description.txt" & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\logo.jpg" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\logo.jpg" & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\Notes.txt" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\Notes.txt" & 
COPY "$(SolutionDir)Plugins\$(ProjectName)\License.txt" "$(SolutionDir)Presentation\Nop.Web\Plugins\VESSEA.Template\License.txt"


