using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace Gamekit2D
{
    public class InputDisplayUI : MonoBehaviour
    {
        private void OnEnable()
        {
            TextMeshProUGUI textUI = GetComponent<TextMeshProUGUI>();
            if (PlayerInput.Instance == null)
            {
                textUI.SetText("## ERROR ## No PlayerInput detected");
                return;
            }

            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("{0} - Mover para a esquerda\n", PlayerInput.Instance.Horizontal.negative.ToString());
            builder.AppendFormat("{0} - Mover para a direita\n", PlayerInput.Instance.Horizontal.positive.ToString());
            builder.AppendFormat("{0} - Olhar para cima\n", PlayerInput.Instance.Vertical.positive.ToString());
            builder.AppendFormat("{0} - Olhar para baixo ou Descer plataformas\n", PlayerInput.Instance.Vertical.negative.ToString());
            builder.AppendFormat("{0} - Pular\n", PlayerInput.Instance.Jump.key.ToString());
            builder.AppendFormat("{0} - Atirar ou Ativar plataformas\n", PlayerInput.Instance.RangedAttack.key.ToString());
            builder.AppendFormat("{0} - Ataque fisico\n", PlayerInput.Instance.MeleeAttack.key.ToString());
            builder.AppendFormat("{0} - Pausar o jogo ou abrir Menu\n", PlayerInput.Instance.Pause.key.ToString());

            textUI.SetText(builder);
        }
    }
}