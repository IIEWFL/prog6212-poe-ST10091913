   M S B A M L   `   `   `  ����  ContractMonthlyClaimSystem2    ,ContractMonthlyClaimSystem.TrackStatusWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Track Claim Status��5   	   $	��400��6$   $	��600��61   .��5      � .+�5   
   �� $��Lecturer Name:��6   $
��Left=�6)   $	��Top=�6D   $��	10,10,0,0q�6\   �� 5   
   -   5         ��Name$ txtLecturerNameSearch��5      $
��Left=�61   $	��Top=�6L   $	��200��6d   $��
120,10,0,0q�6p   �� 5	   
   -   5        $��Search��5	      $
��Left=�6"   $	��Top=�6=   $��
340,10,0,0q�6U   6i   �� 5   
   -   5         ��Name$ ClaimsListView��5      $��10,50,10,10q�6+    �� SelectionMode$ Single=�6@    �� View 5      �� 5      .P�5      �� $��Lecturer Name��6%    �� Width$	 120��6<    �� DisplayMemberBinding 6H   �� *LecturerName+�� 5      $��Hours Worked��6%   $	 120��6;    6G   �� *HoursWorked+�� 5      $��Hourly Rate��6%   $	 120��6:    6F   �� *
HourlyRate+�� 5      $��Notes��6%   $	 200��64    6@   �� *AdditionalNotes+�� 5      $
��File��6%   $	 100��63    6?   �� *UploadedFileName+�� 5      $��Status��6%   $	 100��65    6A   �� *Status+5      5      5      5      