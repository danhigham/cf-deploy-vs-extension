   M S B A M L   `   `   `  ����R  NMyExtension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=512d566d7de30037yAclr-namespace:Pivotal.CFDeployExtension.Dialogs.DeployWizardSteps3Pivotal.CFDeployExtension.Dialogs.DeployWizardSteps  5      E    ?Pivotal.CFDeployExtension.Dialogs.DeployWizardSteps.OrgAndSpace   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:Pivotal.CFDeployExtension.Dialogs.DeployWizardSteps     5      $	��500��5      $��228.08��6   $��5,5,5,5q�6*     � 	Resources  5
       �� 
TargetType �� Property �� Value��%�  '��       '�� �     'G� �    �� 5   
   " ��6   .�5      ��  � ��$3 -pack://application:,,,/Fonts/#Source Sans Pro)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 15px(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$3 -pack://application:,,,/Fonts/#Source Sans Pro)�6+   �� 5       � ��$
 15px(�6)   �� 5       � �� 5      ��5      	#FEEE��6-   5      5      �� 5   
   " G�6   .�5      ��  � ��$3 -pack://application:,,,/Fonts/#Source Sans Pro)�6+   �� 5       � ��$
 15px(�6)   �� 5       � �� 5      ��5      	#FEEE��6-   5       5!      5"      .��5$      �  � RowDefinitions 5%   
   �� 5&      $��30 �6   6*   �� 5'      $��25 �6   6*   �� 5(      $��30 �6   6*   �� 5)      $��25 �6   6*   �� 5*      $��30 �6   6*   �� 5+      $��25 �6   6*   �� 5,      $	��140 �6   6+    � ColumnDefinitions 50   
   �� 51      $	��250 �6   6-   �� 52      $	��250 �6   6-   .+�55   
   �� $��0��6   $��Bottom=�6   $��Organization��68   �� 57   
   $��2��6   $��Bottom=�6   $��Space��68   �� 59   
   $��4��6   $��Bottom=�6   $��Application Name��68   �� 5:   
   $��6��6   $	��100��6   $��25��6*   $��130,10,20,105q�66   $��1��6M   .��6]   Next >6e   �� 5<   
   -   5         ��Name$ spaceCmb��5<      $
��Left=�6%   $��3��6@   $	��Top=�6M   $	��245��6e   $��25��6q    �� SelectedValuePath$	 Key��6}    �� DisplayMemberPath$ Value��6�   ��6�   �� 	 �� Path$	 	SpaceList�
 �� SelectedValue
 6�   �� $	 Space�6�   �� 5=   
   -   5        $ orgCmb��5=      $��1��6#   $	��Top=�60   $��25��6H   $��0,0,5,0q�6T   $	 Key��6e   $ Value��6}   ��6�   �� $	 OrgList�
 6�   �� $	 Organization�6�   �� 5>   
   -   5        $ 
appNameCmb��5>      $
��Left=�6'   $��5��6B   $	��Top=�6O   $	��245��6g   $��25��6s    �� 
IsEditable . $	 Key��6�   $ Value��6�   ��6�   �� $	 ApplicationList�
 6�   �� $	 Application�5?      5@      