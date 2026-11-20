// The overclocking & power limit notice, word for word as the owner wrote it, and its version.
// A new wording gets a new Version: a consent given to another version is asked again (OcConsent.Needs).
// The screen shows these Korean lines (the app is Korean only). Shown by Pages/OverclockConsentDialog.cs.
// No Avalonia here: the GPU tests link this file.
namespace SystemBoost.App.Services;

public static class OverclockNotice
{
    /// The wording's version, kept with every consent in consents.json.
    public const string Version = "2026-11-18";

    public const string Icon = "⚠️";
    /// Bold, after the icon.
    public const string Headline = "오버클럭 · 전력 제한 안내";
    public const string Risk = "오버클럭과 전력 제한 변경은 그래픽카드를 제조사 기본값보다 높은 조건에서 동작하게 합니다.";
    public const string Damage = "이로 인해 시스템 불안정, 게임 충돌, 발열 증가, 부품 수명 단축, 하드웨어 손상이 생길 수 있습니다. 그래픽카드·PC 제조사의 보증을 받지 못할 수도 있습니다.";
    public const string Recovery = "SystemBoost는 온도 감시와 자동 복구 기능을 제공하지만, 모든 문제를 막을 수는 없습니다.";
    /// Bold.
    public const string Responsibility = "이 기능을 켜고 사용하는 결정과 그로 인한 결과의 책임은 사용자 본인에게 있습니다.";
    public const string Exclusion = "단, SystemBoost의 고의 또는 중대한 과실로 생긴 손해는 예외로 합니다.";
    /// The checkbox.
    public const string Agreement = "위 내용을 읽고 이해했으며, 본인 책임으로 사용하는 데 동의합니다.";

    /// The paragraphs between the headline and the checkbox, each as its lines.
    public static readonly string[][] Paragraphs =
    {
        new[] { Risk, Damage },
        new[] { Recovery },
        new[] { Responsibility, Exclusion },
    };

    /// What a tuning write answers without a consent to this version for this card (nothing changed).
    public const string NotAgreed = "오버클럭 · 전력 제한 안내에 동의해야 쓸 수 있어요";
}
