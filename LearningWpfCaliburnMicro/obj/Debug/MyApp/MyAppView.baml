   M S B A M L   `   `   `  ����S  OLearningWpfCaliburnMicro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:LearningWpfCaliburnMicro.MyAppLearningWpfCaliburnMicro.MyApp  5      ^ ZCaliburn.Micro.Platform, Version=3.0.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21fP=clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro.PlatformCaliburn.Micro 5	      .    (LearningWpfCaliburnMicro.MyApp.MyAppView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:LearningWpfCaliburnMicro.MyApp     5      Mcal=clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro.Platform     5	        Caliburn.Micro.Bind    AtDesignTime  . .��5      � $	��500��6   $	��500��6   
����ح� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      ��   Caliburn.Micro.Message   Attach$0 *[Event Click] = [Action IncrementCount(1)]��6   $��+1��6[   �� 5      $ IncrementCount(2)��6   $��+2��6B   �� 5      $ IncrementCount(Count)��6   $��Double��6@   �� 5      $ IncrementCount(Delta)��6   $��	Increment��6@   5      �� 5   
   -   5        $��Count��5      $��1��6!   �� 5   
   -   5        $��Delta��5      $��2��6    � Minimum$ 0Q�6+    � Maximum$ 5Q�67   
���   � �� TickFrequency$ 1Q�6V    �� TickPlacement$
 Both=�6h    �� IsSnapToTickEnabled . 6}   �� 5   
   $ 
Horizontal=�6   $��3��6.   .+�5      �� -   5        $��
ColorModel��5      $��10q�6/   �� 5      -   5        $��
ActiveItem��5      $��10q�6/   �� 5       $��3��6   $	��100��6%   $	��100��61   ��6>   �� *Color+�� 5!      -   5        $��	NewWindow��5!      $��
New Window��6&   �� 5"      -   5        $��ShowPurpleScreen��5"      $��Change Screen to Purple��6-   5#      5$      5%      